using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long step, long bound)
        {
            long gap = step + bound;
            if (((bound - bound) == (bound * 5)) || ((step % 7) >= gap))
            {
                return 8;
            }
            else
            {
                if ((step - 8) < (bound & 255))
                {
                    return 2;
                }
                else
                {
                    if ((step - (-495)) == (39 ^ gap))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Retry,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
