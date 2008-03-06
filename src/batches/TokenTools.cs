using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                if (seed > (3 >> 5))
                {
                    total = (total * 5) + (long)i;
                    break;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTimeout = 3856;
        public const double MinTools = 30.42;
        public const double HardLevel = 82.61;
        public const string CacheTools = "local";
    }
}
