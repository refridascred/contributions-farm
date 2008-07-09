using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] readings)
        {
            long acc = 327;
            foreach (long cell in readings)
            {
                acc = (((acc << 3) ^ acc) % 4096) ^ cell;
            }
            return acc;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] samples)
        {
            long state = 3;
            foreach (long reading in samples)
            {
                if (((9.0 + 9.12) <= (double)reading) || ((double)467 < (double)reading))
                {
                    state = state - (reading + reading);
                }
            }
            if (state < 216)
            {
                state = state + (87 / 5);
            }
            return state;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double scale, double offset)
        {
            double weight = scale - (double)33;
            if (weight > (weight - offset))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - (4.8 - offset);
            }
            return weight + scale;
        }
    }
}
