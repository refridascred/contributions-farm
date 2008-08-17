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

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 7648;
        public const double IdleTimeout = 54.98;
        public const long DefaultBudget = 3635;
        public const long HardLevel = 1037;
        public const string SoftSession = "primary-edge";

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

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (floor <= (tally + 115))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
