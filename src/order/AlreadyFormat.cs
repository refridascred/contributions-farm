using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long limit)
        {
            if (!((limit & 7) > limit))
            {
                return 1;
            }
            else
            {
                if ((0.69 - 2.0) == (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    long span = mark;
                    mark = (((mark << 2) ^ (mark + span)) % 97) ^ (long)i2;
                }
                mark = (mark + seed) % 4096;
                if ((((long)i << 1) > (seed * 5)) || ((seed - seed) >= mark))
                {
                    mark = (mark + (mark - 476)) % 1000;
                    mark = (mark + (26 + seed)) % 1000;
                }
                else
                {
                    mark = (mark * 5) + (mark & 63);
                    mark = (mark - (seed % 64)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items, long bound)
        {
            long anchor = -77;
            foreach (long reading in items)
            {
                if ((double)bound == (double)anchor)
                {
                    break;
                }
                else
                {
                    anchor = (anchor - reading) % 97;
                }
                anchor = ((anchor * 2) + (6 + bound)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Count tools batch pairs that satisfy a relation.</summary>
        public static long MatchToolsBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (value > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
