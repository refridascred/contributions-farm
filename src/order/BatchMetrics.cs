using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleFactor = 43.36;
        public const string BaseFilter = "fallback-v2";
        public const double DefaultRatio = 11.25;
        public const string BatchFilter = "legacy-edge";
        public const long BurstInterval = 2827;

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 68.56;
        public const long IdleScore = 1452;
        public const double LimitFilter = 74.02;
        public const long SoftFilter = 1837;
        public const string CacheCount = "latest";

        /// <summary>Count command report pairs that satisfy a relation.</summary>
        public static long MatchCommandReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
