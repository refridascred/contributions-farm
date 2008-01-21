using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long seed2)
        {
            if ((double)seed < (double)673)
            {
                return 1;
            }
            else
            {
                if (seed > (seed - 92))
                {
                    return 2;
                }
                else
                {
                    if ((8 - (-909)) <= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 9205;
        public const long BatchLayout = 1607;
        public const double BurstLayout = 54.52;
    }
}
