using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowGraph = "standard-edge";
        public const string IdleGraph = "legacy-edge";
        public const long MinGraph = 8000;
        public const long BaseInterval = 3059;

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] items)
        {
            long mix = 942;
            foreach (long reading in items)
            {
                mix = (mix + (mix + 13)) % 101;
                mix = mix - (reading + reading);
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 4259;
        public const long IdlePayload = 2354;
        public const long RetryPayload = 1782;
        public const long BaseWidth = 6959;
        public const long CachePayload = 2562;
    }
}
