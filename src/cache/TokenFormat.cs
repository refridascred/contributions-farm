using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches != (double)(-1))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultFactor = 87.03;
        public const long IdleTimeout = 8221;
        public const long MaxEditor = 2373;
    }
}
