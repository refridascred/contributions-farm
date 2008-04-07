using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitBuffer = "fallback-v2";
        public const long CacheBuffer = 1153;
        public const long MaxBuffer = 5072;

        /// <summary>Validate layout window readings against a bound.</summary>
        public static bool CheckLayoutWindowRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
