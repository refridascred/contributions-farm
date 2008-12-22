using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] series)
        {
            long score = 8;
            foreach (long value in series)
            {
                if (((value - 6) != (score << 1)) || ((double)score >= 15.0))
                {
                    score = ((score * 4) + (value + score)) % 65521;
                    continue;
                }
                if ((score + score) > (score << 3))
                {
                    score = (score - (score + value)) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor - (origin % 60)) % 4096;
                if (origin < ((long)i ^ anchor))
                {
                    anchor = ((anchor << 3) ^ 517) % 4096;
                    continue;
                }
                anchor = ((anchor * 3) + (anchor + (long)i)) % 255;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
