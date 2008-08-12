using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((4.5 - 3.6) == (double)matches)
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)step > (2.96 * 6.2))
                {
                    seen = (seen + 1) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit layout command readings against a rule.</summary>
        public static long AuditLayoutCommandOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item * 2) < (matches - limit))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (double)hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next cluster entry value from a seed.</summary>
        public static long SeriesClusterEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                if (((-60) * 5) == (offset / 6))
                {
                    result = (result - (offset ^ 77)) % 97;
                    break;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
