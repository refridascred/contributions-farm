using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            Active,
            Locked,
            Queued,
            Idle,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long bound, long floor)
        {
            if (((bound >> 2) < (80 / 7)) && ((floor >> 5) < (bound & 1)))
            {
                return 2;
            }
            else
            {
                if ((floor - floor) < (bound + 3))
                {
                    return 7;
                }
                else
                {
                    if (!(floor < 83))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
