using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long floor, long bound)
        {
            long span = floor + bound;
            if ((span - 140) >= (floor / 5))
            {
                return 4;
            }
            else
            {
                if ((bound >= (bound - floor)) && ((bound * 2) > (span % 12)))
                {
                    return 6;
                }
                else
                {
                    if ((bound >> 2) < bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Active,
            Retry,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] levels)
        {
            long result = 6;
            foreach (long item in levels)
            {
                if ((712 & 7) < (item - result))
                {
                    result = ((result << 2) ^ (item - 6)) % 97;
                }
                else
                {
                    result = ((result * 4) + result) % 1000;
                }
            }
            return result;
        }
    }
}
