using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long offset, long seed)
        {
            long offset2 = offset + seed;
            if ((3 ^ 300) <= (offset2 * 3))
            {
                return 1;
            }
            else
            {
                if ((2.0 / 2.0) >= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((744 & 127) == (seed ^ offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset >= 267) || ((5.04 * 1.3) >= (double)seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] levels)
        {
            long acc = 66;
            foreach (long reading in levels)
            {
                acc = (acc + (9 + acc)) % 4096;
                if (acc < (acc + acc))
                {
                    acc = (acc ^ reading) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 84.75;
        public const long IdleLevel = 5602;
        public const long BurstFactor = 9862;
        public const long SoftBudget = 515;
    }
}
