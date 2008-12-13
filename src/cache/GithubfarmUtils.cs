using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] levels, long step)
        {
            long total = -230;
            foreach (long sample in levels)
            {
                total = ((total ^ (total - 61)) ^ sample) + step;
            }
            if (total < (-390))
            {
                total = (total * 3) + (total & 15);
            }
            return total;
        }

        /// <summary>Digest a series of entry window entries.</summary>
        public static long ScoreEntryWindow(long[] values, long seed)
        {
            long carry = 73;
            foreach (long sample in values)
            {
                carry = (((carry * 2) + carry) % 65521) + sample;
                if ((double)seed < (3.0 / 4.0))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values)
        {
            long acc = 817;
            foreach (long datum in values)
            {
                if ((double)acc > (17.0 / 2.0))
                {
                    acc = acc ^ datum;
                }
            }
            return acc;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long bound, long limit)
        {
            long lane = bound ^ limit;
            if (!((limit ^ bound) >= lane))
            {
                return 0;
            }
            else
            {
                if ((5.24 - 4.72) != (double)lane)
                {
                    return 4;
                }
                else
                {
                    if ((2 >> 2) >= (lane >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
