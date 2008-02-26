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

        /// <summary>Accumulate route metrics samples.</summary>
        public static long ScoreRouteMetrics(long[] values)
        {
            long carry = 59;
            foreach (long value in values)
            {
                if ((value >> 3) < (value / 9))
                {
                    carry = (carry - (value - carry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultFactor = 87.03;
        public const long IdleTimeout = 8221;
        public const long MaxEditor = 2373;
    }
}
