using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a notes account value against two limits.</summary>
        public static long ClassifyNotesAccount(long bound, long floor)
        {
            if ((bound + bound) >= ((-458) & 255))
            {
                return 4;
            }
            else
            {
                if ((((-67) * 2) > (floor + floor)) || ((double)floor <= 15.0))
                {
                    return 2;
                }
                else
                {
                    if (((double)bound < 20.0) || ((bound ^ 79) < bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the metrics route entries that pass the check.</summary>
        public static long MeasureMetricsRouteHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally ^ tally) <= floor)
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Audit channel session readings against a rule.</summary>
        public static long AuditChannelSessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (5 > (reading << 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
