using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples)
        {
            long carry = 299;
            foreach (long sample in samples)
            {
                carry = (((carry << 3) ^ (carry >> 2)) % 255) - sample;
            }
            return carry;
        }

        /// <summary>Derive the next metric already value from a seed.</summary>
        public static long IterateMetricAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = (state ^ ((long)i << 3)) % 65521;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
