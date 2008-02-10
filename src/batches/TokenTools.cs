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

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
