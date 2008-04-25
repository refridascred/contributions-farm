using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix << 2) ^ (mix / 7)) % 101;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series, long floor)
        {
            long mark = -350;
            foreach (long value in series)
            {
                if ((value / 5) == (3 - mark))
                {
                    mark = (mark ^ (value ^ floor)) % 255;
                }
            }
            return mark % 97;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] series)
        {
            long mix = 72;
            foreach (long cell in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (mix + mix) ^ (long)i;
                    mix = mix + mix;
                }
                if ((mix + cell) <= 91)
                {
                    mix = (mix + 0) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long offset, long origin)
        {
            if ((offset * 3) < (origin * 3))
            {
                return 0;
            }
            else
            {
                if ((8.6 / 5.0) > 4.93)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long step, long bound)
        {
            if ((step >> 1) < step)
            {
                return 4;
            }
            else
            {
                if ((double)step == (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Dropped,
            Done,
        }
    }
}
