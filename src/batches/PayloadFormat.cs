using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((double)value <= (11.0 + 18.0)) || (value <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinBudget = 424;
        public const string MinTools = "standard-edge";
        public const double LimitTools = 70.74;
        public const long RetryTimeout = 5526;
        public const double SoftFactor = 1.02;

        /// <summary>Audit context schema readings against a rule.</summary>
        public static long MeasureContextSchemaOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((target + target) >= (-665))
                {
                    hits = (hits + 1) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
