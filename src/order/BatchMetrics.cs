using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] data, long floor)
        {
            long mark = 556;
            foreach (long cell in data)
            {
                if ((floor << 2) >= (24 - mark))
                {
                    mark = (mark + (cell ^ 790)) % 101;
                }
            }
            if (mark > 687)
            {
                mark = (mark + 7) % 255;
            }
            return mark;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 3659;
        public const string BurstTools = "alpha-1";
        public const long WindowTools = 3204;
        public const long BurstSize = 7153;
        public const string DefaultFactor = "strict";

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLayout = 94.64;
        public const long IdleTimeout = 3329;
        public const long CacheLayout = 4361;
        public const long BatchLayout = 5809;
        public const string MinLayout = "open-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "stable-v2";
        public const long CacheEntry = 8950;
        public const long MinInterval = 4736;
        public const long LimitEntry = 6018;
        public const string IdleInterval = "open-edge";
    }
}
