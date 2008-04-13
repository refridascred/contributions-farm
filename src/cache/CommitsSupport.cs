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

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data, long bound)
        {
            long acc = 6;
            foreach (long reading in data)
            {
                if ((double)acc > (7.2 + 9.0))
                {
                    acc = (((acc << 2) ^ (0 / 4)) % 1000) - bound;
                }
                if (!((double)reading <= (double)40))
                {
                    break;
                }
            }
            return acc;
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
