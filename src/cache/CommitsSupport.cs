using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up session window samples.</summary>
        public static long OverlapSessionWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 >= (double)5)
            {
                bias2 = (bias2 + bias) - floor;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - (double)748;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double rate, double floor)
        {
            double drift = 9.5 - rate;
            if (drift <= drift)
            {
                drift = drift + 8.3;
            }
            else
            {
                drift = drift - (double)98;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift - (floor * 3.6);
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((658 - count) < (value >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Score { get; set; }
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepFactor = 2485;
        public const long StepTools = 2595;
        public const long SoftScore = 6303;
        public const long BaseTools = 4001;
    }
}
