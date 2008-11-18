using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Draft,
            Paused,
            Stale,
            Queued,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((51 + offset) >= (reading - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchBudget = "primary";
        public const string MinRatio = "alpha-1";
        public const double IdleTools = 55.25;
        public const long StepTools = 1258;
        public const long BurstTools = 7216;

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
