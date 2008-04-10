using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((7.3 * 16.0) == (double)seed)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Accumulate account metric samples.</summary>
        public static long WeighAccountMetric(long[] samples)
        {
            long anchor = 902;
            foreach (long item in samples)
            {
                anchor = anchor + (anchor ^ item);
                if ((4.4 / 6.0) == (double)item)
                {
                    anchor = (anchor * 2) + (item + 2);
                }
            }
            return anchor;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Pending,
            Locked,
            Queued,
        }
    }
}
