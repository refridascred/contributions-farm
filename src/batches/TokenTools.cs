using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 91.84;
        public const long DefaultSize = 114;
        public const long LimitFactor = 3474;
        public const long BatchRatio = 3661;
        public const long WindowRecord = 2425;

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] items, long offset)
        {
            long acc = 1;
            foreach (long item in items)
            {
                if (offset >= (55 * 4))
                {
                    acc = ((acc - acc) % 4096) + item;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
