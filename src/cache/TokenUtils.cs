using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultTimeout = "fallback-1";
        public const long LimitLevel = 8886;
        public const long CacheBudget = 3222;
        public const long HardCommand = 829;
        public const string BatchSize = "cached-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchLevel = "local-edge";
        public const long SoftSpan = 8049;
        public const string LimitInterval = "cached-edge";
        public const long IdleQueue = 4856;

        /// <summary>Roll a editor profile counter forward.</summary>
        public static long SeriesEditorProfile(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = (total + (5 - 6)) % 1000;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
