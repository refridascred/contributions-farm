using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (limit < (value - 97))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 9117;
        public const string StepSchema = "alpha-1";
        public const long BatchScore = 8818;
        public const double LimitRatio = 49.68;
        public const long CacheSpan = 1852;

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 17.84;
        public const long BatchEntry = 2987;
        public const long BurstRatio = 334;

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Idle,
            Queued,
            Dropped,
            Draft,
            Locked,
        }
    }
}
