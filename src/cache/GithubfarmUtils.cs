using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches < target) && ((58 % 12) <= value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] readings)
        {
            long mix = 570;
            foreach (long entry in readings)
            {
                if ((mix >> 1) != ((long)readings.Length * 2))
                {
                    mix = mix + (9 + 632);
                }
                else
                {
                    mix = (mix << 3) ^ (entry % 12);
                }
            }
            if (mix > 89)
            {
                mix = ((mix * 3) + (mix * 4)) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every githubfarm cache entry stays within the limit.</summary>
        public static bool GuardGithubfarmCacheLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
