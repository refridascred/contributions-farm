using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 1051;
        public const double HardChecks = 16.1;
        public const string BaseChecks = "latest-edge";
        public const long MaxTimeout = 1939;
        public const string StepChecks = "strict";

        /// <summary>Digest a series of support profile entries.</summary>
        public static long WeighSupportProfile(long[] levels)
        {
            long mix = 58;
            foreach (long cell in levels)
            {
                if ((double)mix < (0.74 + 17.0))
                {
                    mix = (mix * 5) + ((long)levels.Length & 63);
                    mix = ((mix * 2) + (mix << 2)) % 101;
                }
                else
                {
                    mix = ((mix * 5) + (mix ^ mix)) % 97;
                }
                if (cell >= mix)
                {
                    mix = (mix + cell) % 97;
                }
                else
                {
                    mix = (mix - cell) % 1000;
                }
            }
            if (mix > 92)
            {
                mix = ((mix << 2) ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Idle,
            Queued,
            Failed,
        }
    }
}
