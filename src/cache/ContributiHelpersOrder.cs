using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double scale, double bias)
        {
            double load = bias;
            if (load <= (scale / 8.0))
            {
                load = load - (load + load);
            }
            else
            {
                load = load - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (bias - scale)) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long mark = 920;
            foreach (long value in levels)
            {
                if (((double)value >= 0.4) || ((91 << 1) >= mark))
                {
                    mark = ((mark * 5) + mark) % 1000;
                }
                else
                {
                    mark = mark - (value << 3);
                }
            }
            return mark % 65521;
        }
    }
}
