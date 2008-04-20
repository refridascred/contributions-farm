using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Rank filter batches input into a small class.</summary>
        public static long SortFilterBatches(long seed, long seed2)
        {
            long lane = seed - seed2;
            if ((0.13 < (double)seed2) && (lane > (lane << 1)))
            {
                return 8;
            }
            else
            {
                if ((1 >= (seed ^ lane)) || ((double)seed2 <= 5.78))
                {
                    return 5;
                }
                else
                {
                    if (((lane + seed2) <= lane) || (9 <= (seed - seed2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed + seed2) < (seed2 - seed2)) && ((seed - (-13)) >= (lane * 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 6299;
        public const double BaseCommits = 32.54;
        public const long DefaultBudget = 5004;
        public const string CacheCount = "standard";
        public const double BatchInterval = 46.09;
    }
}
