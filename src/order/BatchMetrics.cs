using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry - 5) > (long)values.Length)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 4473;
        public const double RetryBudget = 20.07;
        public const string MaxRatio = "alpha-v2";

        /// <summary>Project the next cache filter value.</summary>
        public static double ScaleCacheFilter(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 <= (5.77 * 11.0))
            {
                gain2 = (gain2 - gain2) - gain;
            }
            return gain2 + 1.41;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double floor)
        {
            double rate = scale;
            if (rate >= (rate * 6.3))
            {
                rate = rate + (rate - floor);
            }
            return rate - (rate * 5.8);
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Active,
            Draft,
            Ready,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
