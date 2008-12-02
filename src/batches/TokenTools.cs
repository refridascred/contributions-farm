using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long seed, long origin)
        {
            if ((seed << 2) < seed)
            {
                return 2;
            }
            else
            {
                if (origin >= (seed - seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed + origin) < (origin + 451))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long sum = 7;
            foreach (long item in samples)
            {
                if (item <= (item % 5))
                {
                    sum = (sum + (item >> 3)) % 1000;
                    continue;
                }
                if ((double)item <= (6.0 / 3.0))
                {
                    sum = ((sum << 2) ^ (sum - sum)) % 101;
                }
                if (sum >= (item + item))
                {
                    sum = (sum - (long)samples.Length) % 255;
                }
            }
            if (sum < 87)
            {
                sum = (sum * 2) + (78 - sum);
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] series)
        {
            long anchor = 2;
            foreach (long entry in series)
            {
                long cur = (entry - entry) * 2;
                if ((anchor << 3) >= cur)
                {
                    anchor = ((anchor << 2) ^ (anchor - cur)) % 101;
                    cur = (cur + entry) % 101;
                }
                if ((entry & 31) == (anchor + entry))
                {
                    anchor = ((anchor << 3) ^ (anchor & 255)) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ (504 / 5);
                }
            }
            if (anchor < 21)
            {
                anchor = (anchor - (768 + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
