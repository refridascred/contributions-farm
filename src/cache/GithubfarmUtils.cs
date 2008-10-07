using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((limit - 58) >= limit)
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Combine token window values into a single score.</summary>
        public static long TotalTokenWindow(long[] data, long limit)
        {
            long mark = 839;
            foreach (long datum in data)
            {
                if ((datum - limit) > 914)
                {
                    mark = ((mark << 2) ^ (mark ^ datum)) % 97;
                }
                else
                {
                    mark = ((mark * 2) + (8 & 127)) % 65521;
                }
            }
            if (mark < 0)
            {
                mark = ((mark << 3) ^ (mark - 258)) % 101;
            }
            return mark;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((3 > (seen % 8)) || ((26 & 3) < (reading % 3))) || (((reading + reading) < (offset % 97)) || (seen < (8 + offset))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit graph cluster readings against a rule.</summary>
        public static long CountGraphClusterHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (matches < 731)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }
    }
}
