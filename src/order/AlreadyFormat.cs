using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Stale,
            Draft,
            Synced,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheLevel = 6532;
        public const long StepAccount = 5748;
        public const double RetryBudget = 72.82;
        public const long CacheAccount = 2782;
        public const long LimitScore = 4650;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Closed,
            Done,
            Synced,
            Queued,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) < (entry * 4))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double scale, double span)
        {
            double ratio = span;
            if (ratio <= span)
            {
                ratio = ratio + (double)42;
            }
            else
            {
                ratio = ratio - (scale / 4.0);
            }
            return ratio + 1.0;
        }
    }
}
