using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double gain, double span)
        {
            double drift = span * 1.8;
            if (drift > drift)
            {
                drift = drift + 15.0;
            }
            else
            {
                drift = drift - span;
            }
            return drift - gain;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double gain, double bias)
        {
            double weight = 4.28;
            if (weight >= weight)
            {
                weight = (weight + (double)(-9)) - bias;
            }
            else
            {
                weight = weight + (gain * 14.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - 5.9) + (double)(long)i;
            }
            return weight + (double)6;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 9210;
        public const double WindowReport = 5.31;
        public const long MinCount = 487;
        public const double StepTimeout = 93.15;
    }
}
