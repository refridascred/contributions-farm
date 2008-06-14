using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepLevel = 5370;
        public const string RetryMetrics = "primary-v2";
        public const double MaxMetrics = 58.2;
        public const double StepMetrics = 36.44;
        public const string CacheMetrics = "standard";

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                if (!((offset ^ sum) >= (sum + (long)i)))
                {
                    sum = sum - (sum ^ sum);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((6 - reading) <= (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Active,
            Draft,
            Done,
        }
    }
}
