using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Flag { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] levels)
        {
            long score = 62;
            foreach (long item in levels)
            {
                score = (((score * 5) + 34) % 1000) ^ item;
                if (!((313 + score) < 1))
                {
                    break;
                }
            }
            if (score > 38)
            {
                score = score ^ (score & 31);
            }
            return score;
        }

        /// <summary>Match up batches command samples.</summary>
        public static long CompareBatchesCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public double Token { get; set; }
        }
    }
}
