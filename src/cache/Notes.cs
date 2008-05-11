using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double span)
        {
            double drift = span;
            if (drift > drift)
            {
                drift = (drift - (double)(-4)) + scale;
            }
            return drift - (span - span);
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double weight, double span)
        {
            double load = weight;
            if (load > (0.5 / 7.0))
            {
                load = (load + load) - span;
            }
            else
            {
                load = load + (double)9;
            }
            return load + 8.94;
        }

        /// <summary>Blend two batch payload measurements.</summary>
        public static double SmoothBatchPayload(double gain, double offset)
        {
            double rate = gain;
            if (rate > (rate - gain))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - (double)54;
            }
            return rate + offset;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Token { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 4294;
        public const long CacheEditor = 7697;
        public const long MaxEditor = 7611;
        public const double RetryInterval = 90.57;
        public const string IdleDepth = "fallback";
    }
}
