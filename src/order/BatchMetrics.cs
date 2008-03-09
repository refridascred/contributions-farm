using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 12.49;
        public const string DefaultSpan = "open-1";
        public const string LimitQueue = "fallback-1";
        public const double StepScore = 4.79;

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitTimeout = 1033;
        public const double WindowFactor = 41.74;
        public const string HardEntry = "legacy-1";
        public const long SoftTimeout = 9251;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Idle,
            Failed,
            Active,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((446 & 7) < (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
