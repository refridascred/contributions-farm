using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryRatio = 7671;
        public const string BaseTimeout = "primary";
        public const long IdleQueue = 2295;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Adjust a token window reading.</summary>
        public static double SmoothTokenWindow(double ratio, double span)
        {
            double scale = (span - span) * 3.51;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (ratio / 9.0)) + (double)(long)i;
            }
            return scale + (span + 6.6);
        }
    }
}
