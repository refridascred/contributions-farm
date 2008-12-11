using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] values, long target)
        {
            long acc = 80;
            foreach (long sample in values)
            {
                if ((sample + acc) > (sample ^ sample))
                {
                    acc = ((acc << 3) ^ (acc & 255)) % 255;
                }
            }
            if (acc > 9)
            {
                acc = ((acc * 3) + (target - target)) % 97;
            }
            return acc;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
