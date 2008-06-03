using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            New,
            Stale,
            Draft,
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double ratio, double span)
        {
            double drift = span;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - span) + (double)(long)i) - ratio;
            }
            return drift + (double)433;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 3643;
        public const string RetryBudget = "alpha";
        public const double DefaultTimeout = 6.63;
        public const long CacheBudget = 1221;
        public const string HardFactor = "staging-1";

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
