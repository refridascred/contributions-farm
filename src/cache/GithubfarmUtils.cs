using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] values, long origin)
        {
            long anchor = -4;
            foreach (long item in values)
            {
                if (((double)item <= (3.0 + 0.7)) || ((373 ^ origin) > (400 + item)))
                {
                    anchor = anchor ^ (83 + origin);
                }
                else
                {
                    anchor = ((anchor * 4) + anchor) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long offset, long offset2)
        {
            long next = offset - offset2;
            if (offset2 <= (next - offset2))
            {
                return 2;
            }
            else
            {
                if (offset2 < (79 - next))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset == (double)offset2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.0 - 12.0) == (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] samples, long limit)
        {
            long acc = -64;
            foreach (long item in samples)
            {
                if ((item + limit) != (acc - item))
                {
                    acc = ((acc * 2) + item) % 65521;
                }
                else
                {
                    acc = acc + limit;
                }
            }
            if (acc > 551)
            {
                acc = (acc * 3) + (limit ^ acc);
            }
            return acc;
        }
    }
}
