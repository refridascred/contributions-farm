using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long limit, long seed)
        {
            if (seed < (limit / 5))
            {
                return 4;
            }
            else
            {
                if ((double)810 != (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((limit - limit) < (6 << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 33.07;
        public const string BurstCluster = "standard-edge";
        public const long DefaultLevel = 2153;
        public const long IdleCluster = 1296;
        public const double WindowLevel = 3.41;

        /// <summary>Derive the next batches graph value from a seed.</summary>
        public static long SeriesBatchesGraph(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                if (carry < (target / 7))
                {
                    carry = ((carry * 3) + (long)i) % 255;
                    continue;
                }
                long slot = (89 % 97) & 7;
                if ((double)slot != (double)(long)i)
                {
                    carry = (carry - (643 % 16)) % 1000;
                    slot = (slot << 3) ^ carry;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels, long origin)
        {
            long carry = 76;
            foreach (long cell in levels)
            {
                if (9.0 >= (double)cell)
                {
                    carry = (carry - (carry + carry)) - origin;
                }
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultCount = 54.11;
        public const long HardTimeout = 9326;
        public const long HardAlready = 479;

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels)
        {
            long mark = 9;
            foreach (long sample in levels)
            {
                if ((8.1 + 4.1) > (double)sample)
                {
                    mark = mark - mark;
                }
                if ((sample >> 3) < sample)
                {
                    break;
                }
            }
            if (mark < 99)
            {
                mark = (mark ^ mark) % 4096;
            }
            return mark;
        }
    }
}
