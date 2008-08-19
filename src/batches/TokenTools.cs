using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the schema context entries that pass the check.</summary>
        public static long AuditSchemaContextMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen % 3) != (seen & 255))
                {
                    seen = ((seen + 2) - item) + step;
                }
            }
            return seen;
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
