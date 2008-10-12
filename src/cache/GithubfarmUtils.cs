using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long step, long step2)
        {
            long diff = step ^ step2;
            if ((step2 ^ step2) != (diff - (-929)))
            {
                return 7;
            }
            else
            {
                if ((double)diff > (4.2 - 4.5))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] items, long bound)
        {
            long result = 8;
            foreach (long datum in items)
            {
                if ((double)result < 8.02)
                {
                    result = result + (result + datum);
                }
                result = (result * 4) + (result + (long)items.Length);
                if ((result / 4) < (bound - (-302)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] data)
        {
            long mark = 36;
            foreach (long item in data)
            {
                if (49 < (mark * 4))
                {
                    mark = mark ^ (long)data.Length;
                }
                else
                {
                    mark = ((mark << 2) ^ item) % 1000;
                }
            }
            return mark;
        }
    }
}
