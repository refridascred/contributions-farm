using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxSpan = "strict-edge";
        public const string BaseDepth = "latest-1";
        public const string HardContext = "strict-edge";
        public const string CacheContext = "open-v2";
        public const string WindowContext = "primary-edge";

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }
    }
}
