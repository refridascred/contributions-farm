using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples, long floor)
        {
            long sum = 9;
            foreach (long sample in samples)
            {
                sum = (((sum << 2) ^ (68 + (long)samples.Length)) ^ sample) - floor;
            }
            return sum;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long origin)
        {
            long gap = bound - origin;
            if ((origin / 4) > (bound - gap))
            {
                return 7;
            }
            else
            {
                if ((double)bound > (7.42 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((origin - 629) >= (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] data, long offset)
        {
            long mix = 3;
            foreach (long item in data)
            {
                if (item <= (2 % 3))
                {
                    mix = mix + (offset % 12);
                }
                else
                {
                    mix = ((mix << 3) ^ (mix << 3)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Roll a order profile counter forward.</summary>
        public static long IterateOrderProfile(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] series, long step)
        {
            long anchor = 837;
            foreach (long datum in series)
            {
                if (((double)step != (double)datum) && (step <= datum))
                {
                    anchor = (anchor + (datum - (-1))) % 65521;
                }
                else
                {
                    anchor = (anchor * 4) + step;
                }
            }
            if (anchor < 4)
            {
                anchor = anchor - (step << 2);
            }
            return anchor;
        }
    }
}
