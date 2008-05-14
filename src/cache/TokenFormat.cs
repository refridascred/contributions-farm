using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate record stream readings against a bound.</summary>
        public static bool GuardRecordStreamLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long bound)
        {
            if ((0.7 - 8.64) != (double)floor)
            {
                return 5;
            }
            else
            {
                if ((double)bound > (2.6 / 2.0))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
