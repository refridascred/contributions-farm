using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank report layout input into a small class.</summary>
        public static long RankReportLayout(long seed, long seed2)
        {
            long next = seed + seed2;
            if ((double)seed2 == (8.74 * 4.86))
            {
                return 4;
            }
            else
            {
                if ((seed2 << 3) > seed2)
                {
                    return 8;
                }
                else
                {
                    if (((seed << 2) < (-828)) && ((seed % 5) > (seed << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (1 < ((-7) + next))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Dropped,
            Active,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] values)
        {
            long carry = 27;
            foreach (long cell in values)
            {
                carry = (((carry << 2) ^ (85 & 15)) % 65521) ^ cell;
            }
            if (carry < 4)
            {
                carry = carry ^ 127;
            }
            return carry % 1000;
        }

        /// <summary>Iterate the token format series from a seed.</summary>
        public static long StepTokenFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                long count = (seed & 1) - (324 - acc);
                long seen = count;
                if (((long)i % 3) != (seed + seed))
                {
                    count = count - seen;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
