using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally == (16.0 + 6.27))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                long tally = (offset + anchor) >> 2;
                if (!((offset + tally) == (offset + (long)i)))
                {
                    anchor = ((anchor * 2) + (anchor * 5)) % 97;
                }
                tally = ((tally << 2) ^ (offset + 29)) % 255;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = (state - (floor - state)) % 97;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a metrics report pair into a bucket.</summary>
        public static long BucketMetricsReport(long limit, long limit2)
        {
            if (((96 + limit) <= limit2) && (limit > (limit ^ limit2)))
            {
                return 1;
            }
            else
            {
                if ((600 + limit) <= (limit - limit))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
