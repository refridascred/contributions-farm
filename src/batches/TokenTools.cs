using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 29.8;
        public const double MinInterval = 30.21;
        public const double IdleRatio = 44.63;
        public const double BaseSpan = 72.1;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((double)reading < (5.3 + 9.1)))
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
