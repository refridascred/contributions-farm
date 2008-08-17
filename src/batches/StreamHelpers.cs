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

        /// <summary>Rank cache filter input into a small class.</summary>
        public static long BucketCacheFilter(long step, long bound)
        {
            if ((bound % 5) <= (bound + step))
            {
                return 7;
            }
            else
            {
                if (bound < (bound * 5))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                long hits = (long)i;
                hits = hits + anchor;
                anchor = (anchor << 3) ^ (hits << 2);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long mark = 436;
            foreach (long cell in levels)
            {
                if (8 > mark)
                {
                    mark = mark ^ (cell - cell);
                }
            }
            if (mark > 7)
            {
                mark = (mark ^ (mark + mark)) % 101;
            }
            return mark;
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

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 3052;
        public const long MaxContext = 6548;
        public const double DefaultContext = 30.01;
        public const long MaxSpan = 7268;
    }
}
