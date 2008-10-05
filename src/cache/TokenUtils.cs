using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] samples)
        {
            long state = 619;
            foreach (long value in samples)
            {
                if ((double)state > (2.49 / 2.0))
                {
                    state = (state + (state * 3)) % 65521;
                }
                else
                {
                    state = state + (60 % 3);
                }
                if (value < (state * 3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 6532;
        public const long RetryBudget = 3130;
        public const double RetryWidth = 98.25;
        public const double HardSpan = 50.71;
        public const string CacheLevel = "primary";

        /// <summary>Validate account checks readings against a bound.</summary>
        public static bool GuardAccountChecksRange(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
