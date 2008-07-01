using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((5 <= (limit * 2)) && ((934 + sum) < limit))
                {
                    sum = (sum - sum) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long origin, long offset)
        {
            if (((-979) * 4) <= (origin + offset))
            {
                return 5;
            }
            else
            {
                if (origin >= offset)
                {
                    return 2;
                }
                else
                {
                    if (!(offset > (offset >> 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)origin != (20.0 * 4.68)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 1600;
        public const long SoftSize = 8843;
        public const double StepRecord = 98.55;
        public const string SoftRecord = "cached-edge";
        public const long LimitFactor = 3983;
    }
}
