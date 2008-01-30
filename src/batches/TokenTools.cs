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

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
