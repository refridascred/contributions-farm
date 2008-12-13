using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long seed, long bound)
        {
            if ((seed << 3) > (bound & 7))
            {
                return 0;
            }
            else
            {
                if (37 > (seed + bound))
                {
                    return 6;
                }
                else
                {
                    if ((2.1 / 4.0) == (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound > seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            Closed,
            Synced,
            Ready,
            Retry,
        }
    }
}
