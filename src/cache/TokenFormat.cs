using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
