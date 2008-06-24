using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] series, long floor)
        {
            long acc = 63;
            foreach (long entry in series)
            {
                acc = (((acc ^ (acc >> 2)) % 4096) ^ entry) - floor;
            }
            return acc;
        }

        /// <summary>Count batches channel pairs that satisfy a relation.</summary>
        public static long MatchBatchesChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Draft,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (((seed << 2) < (floor + floor)) && (5 >= (cur * 3)))
            {
                return 6;
            }
            else
            {
                if ((seed * 2) < (floor * 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
