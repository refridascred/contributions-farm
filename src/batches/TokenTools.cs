using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchBudget = 47.87;
        public const long BurstChecks = 6677;
        public const double RetryInterval = 54.77;
        public const string DefaultChecks = "open-edge";
        public const long IdleBudget = 4177;

        /// <summary>Audit profile command readings against a rule.</summary>
        public static long MeasureProfileCommandOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((-25) + hits) == (hits >> 5))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stats githubfarm series from a seed.</summary>
        public static long StepStatsGithubfarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = carry ^ ((long)i * 5);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
