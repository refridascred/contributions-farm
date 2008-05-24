using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels)
        {
            long score = -73;
            foreach (long item in levels)
            {
                score = score ^ (item + item);
                if ((double)75 > (double)item)
                {
                    score = ((score << 3) ^ (item - item)) % 101;
                }
                else
                {
                    score = (score - (score + 1)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long sum = 8;
            foreach (long datum in readings)
            {
                sum = ((sum + sum) % 4096) - datum;
            }
            if (sum < 82)
            {
                sum = (sum + (sum - 393)) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long mark = -19;
            foreach (long cell in readings)
            {
                if (((cell ^ mark) < (cell >> 5)) && ((mark & 7) > (mark >> 5)))
                {
                    continue;
                }
                for (int i = 0; i < 9; i++)
                {
                    mark = (mark - ((long)i / 8)) % 101;
                    mark = ((mark << 3) ^ mark) % 65521;
                }
                mark = mark - 506;
            }
            return mark % 97;
        }
    }
}
