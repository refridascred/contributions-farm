using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a githubfarm profile counter forward.</summary>
        public static long StepGithubfarmProfile(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                result = ((result << 3) ^ ((long)i / 5)) % 97;
                if ((result ^ floor) != (result + result))
                {
                    result = ((result * 5) + (result - result)) % 101;
                    result = result - result;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleInterval = "legacy";
        public const long IdleFilter = 5437;
        public const long RetryFilter = 9628;
        public const long BurstCount = 2209;
        public const long BurstLevel = 1589;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading < (tally >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
