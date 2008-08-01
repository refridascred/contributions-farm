using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the profile order entries that pass the check.</summary>
        public static long MeasureProfileOrderOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches <= 96)
                {
                    matches = (matches + 2) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate channel stream readings against a bound.</summary>
        public static bool GuardChannelStreamLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
