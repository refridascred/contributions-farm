using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every contributi githubfarm entry stays within the limit.</summary>
        public static bool CheckContributiGithubfarmLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (43 * 5)) % 1000;
                if (((total / 2) < total) || ((double)origin == (2.3 * 7.17)))
                {
                    total = (total * 3) + (long)i;
                }
                else
                {
                    total = ((total << 2) ^ (total >> 5)) % 4096;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchWidth = 674;
        public const long SoftScore = 2551;
        public const double MaxGraph = 54.63;
    }
}
