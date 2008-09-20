using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double bias, double span)
        {
            double mean = bias;
            if (mean >= span)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (mean * 1.9);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (bias + mean);
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] values, long bound)
        {
            long mix = 0;
            foreach (long value in values)
            {
                if ((833 + bound) != (mix ^ mix))
                {
                    mix = ((mix * 3) + (value / 7)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Label { get; set; }
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
