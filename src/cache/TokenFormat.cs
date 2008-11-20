using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Pending,
            Closed,
        }

        /// <summary>Blend two checks order measurements.</summary>
        public static double AdjustChecksOrder(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 > (ratio2 / 9.0))
            {
                ratio2 = ratio2 - (ratio2 - span);
            }
            return ratio2 + (ratio / 7.0);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (bound > (bound << 1))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }
    }
}
