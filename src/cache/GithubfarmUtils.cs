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

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Locked,
            Draft,
            New,
            Pending,
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
