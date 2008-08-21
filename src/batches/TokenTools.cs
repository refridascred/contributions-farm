using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string HardLevel = "latest-v2";
        public const double BaseBatch = 59.31;
        public const double MinFactor = 42.49;
        public const string MaxBatch = "open-edge";

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Synced,
            Done,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long seed, long offset)
        {
            long cur = seed + offset;
            if ((194 / 9) >= (cur ^ 479))
            {
                return 6;
            }
            else
            {
                if ((offset + 27) <= cur)
                {
                    return 3;
                }
                else
                {
                    if ((offset + offset) < ((-53) + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
