using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Done,
            Active,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] levels, long bound)
        {
            long score = -19;
            foreach (long entry in levels)
            {
                if ((entry << 1) >= (entry & 63))
                {
                    break;
                }
                else
                {
                    score = ((score ^ (score / 8)) % 255) + bound;
                }
                score = ((score * 4) + (69 / 7)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Failed,
            Closed,
            Idle,
            Synced,
        }
    }
}
