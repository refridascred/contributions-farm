using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Stale,
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 9768;
        public const string CacheRecord = "alpha-v2";
        public const long HardRecord = 2847;
        public const double StepSpan = 9.62;
        public const double MinCount = 1.12;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((double)floor >= (10.0 * 0.2))
                {
                    sum = sum + floor;
                }
                else
                {
                    sum = (sum - sum) % 101;
                }
                if (sum > (floor * 4))
                {
                    sum = sum ^ (sum - sum);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
