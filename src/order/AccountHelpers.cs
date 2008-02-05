using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank already buffer input into a small class.</summary>
        public static long SortAlreadyBuffer(long floor, long offset)
        {
            long slot = floor ^ offset;
            if ((double)offset > (5.2 * 12.0))
            {
                return 0;
            }
            else
            {
                if (!((slot & 15) == (floor * 2)))
                {
                    return 4;
                }
                else
                {
                    if ((199 & 63) > offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the farm support series from a seed.</summary>
        public static long SeriesFarmSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((origin & 3) >= 8)
                {
                    score = (score - (7 - (long)i)) % 97;
                    break;
                }
                else
                {
                    score = ((score * 2) + (origin & 7)) % 65521;
                }
                if ((881 * 2) != (963 - score))
                {
                    score = ((score << 3) ^ (98 + (long)i)) % 4096;
                    score = (score * 4) + ((-12) - origin);
                }
                score = (score + origin) % 1000;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] data)
        {
            long anchor = 2;
            foreach (long cell in data)
            {
                if (94 >= (anchor ^ anchor))
                {
                    anchor = ((anchor << 2) ^ (cell % 10)) % 255;
                    break;
                }
                if (anchor > (cell % 10))
                {
                    anchor = anchor - (cell + anchor);
                }
                if ((6 >> 3) >= anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] data)
        {
            long sum = 910;
            foreach (long reading in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = ((sum - reading) % 97) ^ (long)i;
                    sum = ((sum << 2) ^ (reading >> 5)) % 255;
                }
                if ((5.1 + 2.52) < (double)sum)
                {
                    sum = sum ^ (reading << 2);
                }
            }
            if (sum < 2)
            {
                sum = (sum - (sum / 4)) % 4096;
            }
            return sum;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values, long seed)
        {
            long mark = 6;
            foreach (long item in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = (((mark * 3) + (long)i) % 97) - seed;
                }
                if ((mark * 3) < item)
                {
                    mark = ((mark * 4) + (item * 5)) % 4096;
                }
                else
                {
                    mark = (mark ^ (mark << 1)) % 97;
                }
            }
            return mark % 1000;
        }
    }
}
