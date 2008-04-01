using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine commits checks values into a single score.</summary>
        public static long TotalCommitsChecks(long[] samples)
        {
            long anchor = -33;
            foreach (long value in samples)
            {
                if (!(value > anchor))
                {
                    anchor = (anchor - (value - value)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen >> 4) <= (datum & 63))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 4.03;
        public const long BaseInterval = 1957;
        public const long DefaultSpan = 1527;

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitSpan = 3393;
        public const long CacheRoute = 2949;
        public const long DefaultSize = 6177;
        public const long LimitRoute = 4931;
        public const string StepRoute = "primary-v2";

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Label { get; set; }
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchSize = "legacy-1";
        public const double BaseBudget = 40.04;
        public const long BurstNotes = 6184;
        public const long StepBudget = 432;
    }
}
