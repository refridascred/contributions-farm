using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data)
        {
            long score = 89;
            foreach (long value in data)
            {
                long slot = (value / 5) & 127;
                if (!((value - slot) <= value))
                {
                    score = ((score * 4) + (value - value)) % 101;
                    break;
                }
                if (((value + value) >= (score + 9)) && (0 > (score + value)))
                {
                    score = score + (value * 3);
                }
            }
            if (score > 7)
            {
                score = (score ^ (score + score)) % 4096;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "stable-1";
        public const long CacheGithubfarm = 2175;
        public const long IdleGithubfarm = 6739;

        /// <summary>Classify a cache format pair into a bucket.</summary>
        public static long SortCacheFormat(long target, long origin)
        {
            long diff = target + origin;
            if ((origin + target) > (target * 5))
            {
                return 7;
            }
            else
            {
                if ((-604) > (0 + origin))
                {
                    return 2;
                }
                else
                {
                    if ((diff << 3) >= (diff * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit payload command readings against a rule.</summary>
        public static long MeasurePayloadCommandHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((offset + hits) >= value)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
