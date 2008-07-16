using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWidth = 27.94;
        public const string MinWidth = "standard-v2";
        public const long MinInterval = 4093;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item >= (6.5 * 6.0))
                {
                    seen = (seen + 3) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultFactor = 1432;
        public const double StepBudget = 93.24;
        public const long CacheCommand = 2402;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 3649;
        public const string MaxFactor = "stable-edge";
        public const double HardCount = 5.33;
        public const string BurstCount = "fallback-v2";
        public const long MinBatches = 2313;
    }
}
