using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] items)
        {
            long total = 322;
            foreach (long sample in items)
            {
                total = (total - (total >> 3)) - sample;
            }
            if (total < 217)
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 8026;
        public const long RetryNotes = 267;
        public const long BaseNotes = 3826;
        public const double SoftFactor = 96.88;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Pending,
            Active,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches >= (sample ^ sample)) && ((matches / 8) >= 39))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
