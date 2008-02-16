using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string StepLevel = "local";
        public const long BurstDepth = 4376;
        public const long MaxGraph = 6092;
        public const double IdleGraph = 63.29;
        public const long DefaultGraph = 6614;

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] data, long bound)
        {
            long acc = 2;
            foreach (long entry in data)
            {
                acc = (acc - (bound - entry)) % 65521;
                if ((entry * 5) > (bound * 3))
                {
                    acc = (acc << 2) ^ (bound * 4);
                }
                else
                {
                    acc = (acc ^ (bound >> 4)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] samples, long seed)
        {
            long mix = -457;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((((mix * 3) + seed) % 4096) ^ (long)i) - entry;
                    mix = ((mix << 3) ^ (3 >> 5)) % 97;
                }
                if (!((seed + seed) < mix))
                {
                    mix = mix ^ 423;
                }
            }
            return mix;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
