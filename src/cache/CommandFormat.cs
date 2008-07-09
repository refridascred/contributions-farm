using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((seen & 15) == (336 - seen)) && (seen >= (seen + reading)))
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

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen <= (value ^ 302)) && ((offset / 9) <= (offset + offset)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((4.0 - 13.0) >= (double)item) || ((0.3 - 5.1) > (double)matches)) || !(item >= (0 + 783)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((long)items.Length - 121) > (value & 31))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
