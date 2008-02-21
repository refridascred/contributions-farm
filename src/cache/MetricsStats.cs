using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] values, long floor)
        {
            long score = 499;
            foreach (long cell in values)
            {
                if (0 <= (score / 2))
                {
                    score = (score - score) + floor;
                }
                else
                {
                    score = score + (cell - 3);
                }
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetrySpan = "open-1";
        public const long BatchInterval = 1313;
        public const string StepNotes = "alpha-1";

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length << 3) <= (long)samples.Length)
                {
                    hits = (hits + 1) ^ item;
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
