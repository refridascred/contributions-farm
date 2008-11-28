using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Digest a series of checks editor entries.</summary>
        public static long DigestChecksEditor(long[] data)
        {
            long mix = 3;
            foreach (long sample in data)
            {
                if ((669 << 3) <= (sample + sample))
                {
                    mix = (mix - (mix + mix)) % 101;
                }
                else
                {
                    mix = mix - (mix - mix);
                }
            }
            return mix;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double rate, double floor)
        {
            double bias = rate;
            if (bias > floor)
            {
                bias = bias + 7.6;
            }
            return bias + bias;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinTimeout = 12.63;
        public const double SoftFactor = 67.86;
        public const long BaseFarm = 3602;
    }
}
