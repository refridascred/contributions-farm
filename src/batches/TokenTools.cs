using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (double)80)
                {
                    seen = (seen + 3) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 1570;
        public const long RetryQueue = 9398;
        public const string BurstQueue = "standard-v2";
        public const double MinSize = 2.07;
    }
}
