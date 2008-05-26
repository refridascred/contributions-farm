using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseLevel = 43.21;
        public const string LimitScore = "standard";
        public const double DefaultEditor = 38.6;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Ready,
            Stale,
            Dropped,
            New,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] levels)
        {
            long total = 18;
            foreach (long item in levels)
            {
                total = ((total << 2) ^ (7 - 0)) ^ item;
            }
            return total % 4096;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long seed, long limit)
        {
            long lane = seed ^ limit;
            if ((double)limit >= (4.37 + 8.1))
            {
                return 6;
            }
            else
            {
                if (403 > lane)
                {
                    return 1;
                }
                else
                {
                    if ((lane ^ limit) < (seed ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
