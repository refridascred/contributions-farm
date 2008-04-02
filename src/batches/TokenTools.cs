using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] samples, long offset)
        {
            long sum = 841;
            foreach (long datum in samples)
            {
                if (datum <= (0 - offset))
                {
                    sum = ((sum << 3) ^ (959 ^ 188)) % 1000;
                }
                sum = (sum - (sum % 97)) % 1000;
                if ((double)datum != (double)15)
                {
                    sum = (sum + (sum - sum)) % 255;
                }
                else
                {
                    sum = (sum - (offset + offset)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long origin, long floor)
        {
            long step = origin ^ floor;
            if ((70 >> 2) <= step)
            {
                return 6;
            }
            else
            {
                if (63 <= (origin + step))
                {
                    return 4;
                }
                else
                {
                    if (floor >= (step * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0.6 * 2.4) != (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
