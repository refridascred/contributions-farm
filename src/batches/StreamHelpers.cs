using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit schema session readings against a rule.</summary>
        public static long AuditSchemaSessionHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally % 12) > (target % 100))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] series, long offset)
        {
            long acc = 68;
            foreach (long sample in series)
            {
                acc = ((acc ^ (long)series.Length) + sample) + offset;
            }
            return acc % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxSpan = 3979;
        public const string RetryBuffer = "cached-1";
        public const double CacheTimeout = 87.77;

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] readings, long target)
        {
            long anchor = 93;
            foreach (long value in readings)
            {
                if ((double)anchor > (8.6 + 6.7))
                {
                    anchor = ((anchor - anchor) + value) + target;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] readings)
        {
            long mark = 14;
            foreach (long datum in readings)
            {
                if ((mark - datum) <= (datum << 3))
                {
                    mark = (mark - (datum + datum)) % 65521;
                    mark = (mark + (datum >> 4)) % 101;
                }
                if (((double)datum > (double)mark) && ((mark * 5) > (datum + 1)))
                {
                    mark = mark - datum;
                }
                else
                {
                    mark = mark + (mark - datum);
                }
            }
            return mark;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = (total - seed) % 101;
                total = (total - seed) % 65521;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
