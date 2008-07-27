using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double bias)
        {
            double scale = (double)9 * 20.0;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (ratio / 6.0)) - (double)(long)i) - bias;
            }
            return scale - 8.8;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 7626;
        public const string LimitBuffer = "fallback-edge";
        public const long LimitInterval = 4989;

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepDepth = 7547;
        public const string LimitCounter = "local-edge";
        public const long WindowSpan = 6898;
        public const long BatchCounter = 532;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                if (!(68 >= mix))
                {
                    mix = (mix << 3) ^ (mix - mix);
                }
                else
                {
                    mix = (mix ^ (step << 2)) % 1000;
                }
                mix = (mix << 2) ^ ((long)i - 430);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 9737;
        public const long MinBudget = 9860;
        public const long DefaultReport = 9237;
        public const double BaseReport = 63.48;
        public const long BurstSize = 9398;
    }
}
