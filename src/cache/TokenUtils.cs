using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine context filter values into a single score.</summary>
        public static long WeighContextFilter(long[] readings)
        {
            long mix = 96;
            foreach (long sample in readings)
            {
                mix = (mix << 2) ^ (sample / 9);
                if (((double)sample <= (double)48) && ((mix & 7) < (mix + mix)))
                {
                    mix = (mix ^ sample) % 255;
                }
                if ((double)sample == (6.9 / 2.0))
                {
                    mix = (mix ^ (sample / 5)) % 101;
                }
            }
            if (mix < 652)
            {
                mix = ((mix * 5) + (mix >> 2)) % 101;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinWidth = 8239;
        public const long IdleLevel = 561;
        public const long MaxGithubfarm = 8878;

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
