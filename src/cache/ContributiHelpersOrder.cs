using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Project the next metric graph value.</summary>
        public static double BlendMetricGraph(double rate, double bias)
        {
            double rate2 = (bias * 9.5) - (bias * 3.0);
            return rate2 + (rate - 1.95);
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] samples, long bound)
        {
            long mix = 421;
            foreach (long datum in samples)
            {
                if (((datum & 63) > bound) && ((datum + 412) == (mix + 0)))
                {
                    mix = mix ^ (mix >> 2);
                }
            }
            return mix % 4096;
        }
    }
}
