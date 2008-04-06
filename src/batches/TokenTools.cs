using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 5604;
        public const long BurstCount = 8731;
        public const long MinScore = 2481;

        /// <summary>Rank queue entry input into a small class.</summary>
        public static long ClassifyQueueEntry(long seed, long floor)
        {
            if (((seed + floor) > seed) && ((floor + seed) > (seed + floor)))
            {
                return 2;
            }
            else
            {
                if (!((12.0 + 5.0) >= (double)seed))
                {
                    return 4;
                }
                else
                {
                    if ((floor / 9) < 64)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((floor - floor) < seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseSize = "latest-edge";
        public const long WindowLevel = 5758;
        public const double WindowBudget = 11.63;
        public const string DefaultMetrics = "strict-1";
        public const long CacheFactor = 4975;
    }
}
