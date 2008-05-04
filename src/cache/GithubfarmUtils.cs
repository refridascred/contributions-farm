using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] samples)
        {
            long mix = 607;
            foreach (long value in samples)
            {
                if (!(value >= (value + 221)))
                {
                    mix = (mix ^ (value / 4)) % 65521;
                }
                if ((mix - value) <= (value & 1))
                {
                    mix = (mix * 5) + (86 + value);
                }
                mix = (mix * 2) + (value >> 3);
            }
            return mix;
        }

        /// <summary>Classify a stream payload pair into a bucket.</summary>
        public static long ClassifyStreamPayload(long floor, long limit)
        {
            if ((floor & 63) != (limit / 4))
            {
                return 4;
            }
            else
            {
                if (2.47 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit % 24) > (limit * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardScore = "strict";
        public const double IdleDepth = 90.23;
        public const double RetryCount = 95.48;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] samples, long limit)
        {
            long anchor = 64;
            foreach (long item in samples)
            {
                if ((6 + anchor) != (item >> 4))
                {
                    anchor = anchor ^ (limit * 3);
                }
            }
            return anchor % 1000;
        }
    }
}
