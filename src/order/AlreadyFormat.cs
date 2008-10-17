using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long floor, long origin)
        {
            if ((origin & 3) != (116 / 6))
            {
                return 5;
            }
            else
            {
                if (!((origin + floor) <= (floor - 4)))
                {
                    return 6;
                }
                else
                {
                    if ((4.0 + 8.1) == (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
