using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double rate, double offset)
        {
            double drift = offset;
            if (drift < (offset + offset))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + rate;
            }
            return drift + rate;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 4473;
        public const double RetryBudget = 20.07;
        public const string MaxRatio = "alpha-v2";

        /// <summary>Project the next cache filter value.</summary>
        public static double ScaleCacheFilter(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 <= (5.77 * 11.0))
            {
                gain2 = (gain2 - gain2) - gain;
            }
            return gain2 + 1.41;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double floor)
        {
            double rate = scale;
            if (rate >= (rate * 6.3))
            {
                rate = rate + (rate - floor);
            }
            return rate - (rate * 5.8);
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Active,
            Draft,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxFactor = 4392;
        public const long BurstProfile = 2576;
        public const long IdleSpan = 1017;
        public const long BaseProfile = 415;
    }
}
