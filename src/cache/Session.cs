using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry <= (536 % 8)) || ((entry < offset) || (entry > (matches / 9))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a batches metric counter forward.</summary>
        public static long SeriesBatchesMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                state = (state - (offset & 31)) % 101;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
