using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)matches == (6.3 * 6.0))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cluster stats readings.</summary>
        public static long PairClusterStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((-804) << 2) < (hits % 8))
                {
                    hits = ((hits + 2) - cell) - target;
                }
            }
            return hits;
        }
    }
}
