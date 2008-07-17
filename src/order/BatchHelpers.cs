using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                long tally = floor / 5;
                if (((carry * 4) < carry) || ((9.0 - 4.64) > (double)tally))
                {
                    carry = (carry * 5) + (22 ^ (long)i);
                    tally = (tally - (29 + 97)) % 4096;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item << 3) > tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long seed, long floor)
        {
            if ((4.79 + 14.0) > (double)floor)
            {
                return 6;
            }
            else
            {
                if (floor >= (700 / 3))
                {
                    return 7;
                }
                else
                {
                    if (!((seed ^ seed) < (seed & 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-2) - floor) < (seed + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
