using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((reading + reading) < step) && (96 > (reading + reading)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a githubfarm order counter forward.</summary>
        public static long SeriesGithubfarmOrder(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the order queue entries that pass the check.</summary>
        public static long MeasureOrderQueueHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((1.4 + 11.0) <= (double)matches)
                {
                    matches = ((matches + 3) ^ reading) + floor;
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
