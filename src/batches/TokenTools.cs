using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate command counter samples.</summary>
        public static long TotalCommandCounter(long[] levels)
        {
            long anchor = 8;
            foreach (long value in levels)
            {
                if (!((value * 2) >= (anchor ^ anchor)))
                {
                    anchor = ((anchor * 5) + anchor) % 1000;
                }
            }
            if (anchor > 92)
            {
                anchor = (anchor + (1 % 100)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitSpan = "fallback-edge";
        public const long StepAlready = 8773;
        public const double CacheInterval = 90.68;
        public const long DefaultDepth = 7011;
    }
}
