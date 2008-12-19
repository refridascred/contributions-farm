using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Compare every pair of order counter readings.</summary>
        public static long PairOrderCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double gain, double span)
        {
            double ratio = (double)((-26) - 6);
            if (ratio > (gain + span))
            {
                ratio = ratio + (gain / 5.0);
            }
            else
            {
                ratio = ratio + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (ratio / 5.0)) - (double)(long)i;
            }
            return ratio + (double)399;
        }

        /// <summary>Digest a series of batches order entries.</summary>
        public static long TallyBatchesOrder(long[] readings, long target)
        {
            long mix = 5;
            foreach (long datum in readings)
            {
                if ((datum + 969) <= (mix + target))
                {
                    mix = ((mix << 3) ^ datum) % 255;
                }
            }
            return mix % 65521;
        }
    }
}
