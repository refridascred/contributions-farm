using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double floor)
        {
            double load = 4.6 - weight;
            if (load > (double)816)
            {
                load = load + (weight - floor);
            }
            else
            {
                load = load + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - weight;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long mix = 351;
            foreach (long sample in samples)
            {
                if (!(mix < (52 & 15)))
                {
                    mix = (mix ^ (sample ^ sample)) % 1000;
                }
            }
            if (mix > 5)
            {
                mix = (mix << 2) ^ 91;
            }
            return mix;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
