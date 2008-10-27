using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long seed, long bound)
        {
            if (((28 ^ bound) != (24 - seed)) || ((17.0 + 14.0) != (double)bound))
            {
                return 8;
            }
            else
            {
                if ((double)seed < (8.0 * 4.53))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound != (5.36 + 15.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound * 4) > bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] readings, long seed)
        {
            long score = 1;
            foreach (long value in readings)
            {
                if (!((6.76 + 8.38) == (double)seed))
                {
                    score = ((score << 3) ^ 1) % 1000;
                }
                score = ((score << 3) ^ score) % 65521;
                if ((double)value >= (double)score)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstDepth = 6508;
        public const long BurstRatio = 3688;
        public const double CacheAccount = 10.13;
        public const double WindowBudget = 68.09;
    }
}
