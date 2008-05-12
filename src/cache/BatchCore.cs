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

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double gain2 = span + (1.1 * 3.7);
            if (gain2 > (double)410)
            {
                gain2 = gain2 - (span / 9.0);
            }
            return gain2 + gain;
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
