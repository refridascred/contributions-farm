using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double gain, double span)
        {
            double scale = gain + (gain - span);
            if (scale >= (gain - scale))
            {
                scale = scale + (double)82;
            }
            return scale - (double)0;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheDepth = "staging";
        public const long WindowWidth = 6166;
        public const long BatchToken = 3120;
        public const double DefaultToken = 65.54;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the stream entry entries that pass the check.</summary>
        public static long CountStreamEntryGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value >= (value >> 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
