using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double scale, double span)
        {
            double mean = (scale / 2.0) - scale;
            if (mean <= 3.9)
            {
                mean = mean + span;
            }
            else
            {
                mean = mean + span;
            }
            return mean - (scale * 8.0);
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardLevel = 15.48;
        public const long CacheTimeout = 7707;
        public const long BatchWidth = 3232;
        public const long LimitBatch = 5553;
    }
}
