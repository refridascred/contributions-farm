using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 8441;
        public const string RetryRoute = "alpha";
        public const string HardWidth = "local-v2";
        public const double LimitRoute = 7.97;
        public const string DefaultRoute = "cached-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRatio = 8683;
        public const string IdleRoute = "local";
        public const long StepRoute = 7227;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Locked,
            Draft,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double rate, double bias)
        {
            double mean = (double)((-5) / 3);
            if (mean > rate)
            {
                mean = (mean + mean) + bias;
            }
            return mean + (double)29;
        }

        /// <summary>Accumulate window editor samples.</summary>
        public static long CombineWindowEditor(long[] series)
        {
            long anchor = 88;
            foreach (long sample in series)
            {
                anchor = ((anchor << 2) ^ anchor) - sample;
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the stats token series from a seed.</summary>
        public static long SeriesStatsToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix - (bound % 3)) % 97;
                mix = (mix << 2) ^ (mix + bound);
                mix = (mix ^ (mix - mix)) % 1000;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
