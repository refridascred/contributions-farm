using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double gain, double span)
        {
            double bias = gain;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - (gain + 3.9)) - (double)(long)i) - span;
            }
            return bias + (double)68;
        }
    }
}
