using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepTimeout = 4626;
        public const long MinSize = 2918;
        public const string BatchBudget = "stable-edge";
        public const long StepBuffer = 8093;
        public const double RetryFactor = 25.36;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor * 2) + (anchor & 15);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
