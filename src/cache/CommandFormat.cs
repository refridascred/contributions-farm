using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((double)tally == (5.84 * 6.9)) || ((double)value >= (double)origin))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long seed, long bound)
        {
            long offset = seed + bound;
            if (seed <= (offset % 10))
            {
                return 3;
            }
            else
            {
                if (seed >= (seed + seed))
                {
                    return 0;
                }
                else
                {
                    if ((bound >> 3) > (seed % 64))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next githubfarm checks value from a seed.</summary>
        public static long SeriesGithubfarmChecks(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum << 3) ^ limit;
                if (!((8 + limit) >= limit))
                {
                    sum = sum ^ (long)i;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
