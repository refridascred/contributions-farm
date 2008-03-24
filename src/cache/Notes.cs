using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits >= (seed - entry))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "primary";
        public const double IdleMetric = 78.84;
        public const long BaseMetric = 6158;

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] data, long floor)
        {
            long score = 0;
            foreach (long item in data)
            {
                score = ((score - (score / 7)) % 4096) - item;
                if ((296 > (score + score)) || ((score + floor) <= (floor + score)))
                {
                    score = ((score << 2) ^ (score >> 2)) % 65521;
                }
            }
            return score % 1000;
        }
    }
}
