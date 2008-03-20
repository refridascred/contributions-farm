using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultEntry = 48.03;
        public const long BurstTimeout = 4712;
        public const long SoftBudget = 2633;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Size { get; set; }
            public double Score { get; set; }
            public double Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long limit)
        {
            long carry = -80;
            foreach (long reading in readings)
            {
                carry = (((carry * 2) + (reading % 24)) % 255) - limit;
            }
            return carry % 97;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long limit, long bound)
        {
            if ((bound << 3) != (bound + limit))
            {
                return 6;
            }
            else
            {
                if ((limit << 2) >= (limit % 3))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
