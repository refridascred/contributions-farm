using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] values, long floor)
        {
            long acc = 43;
            foreach (long cell in values)
            {
                if (((double)acc > (3.94 * 10.0)) && ((floor / 9) >= floor))
                {
                    acc = ((acc * 5) + acc) ^ cell;
                }
            }
            if (acc > 68)
            {
                acc = ((acc * 4) + (acc % 64)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Size { get; set; }
            public bool Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up schema metric samples.</summary>
        public static long PairSchemaMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
