using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double weight, double span)
        {
            double ratio = (double)((-10) / 2);
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + span) + (double)(long)i) - weight;
            }
            return ratio - (double)19;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of farm cache entries.</summary>
        public static long TotalFarmCache(long[] series, long step)
        {
            long acc = -6;
            foreach (long entry in series)
            {
                if (0.7 < (double)acc)
                {
                    acc = (((acc << 3) ^ (entry * 5)) % 1000) + step;
                }
            }
            if (acc > 87)
            {
                acc = acc - (acc + (-83));
            }
            return acc;
        }
    }
}
