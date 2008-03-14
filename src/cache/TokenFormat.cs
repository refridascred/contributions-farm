using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] values, long limit)
        {
            long sum = 937;
            foreach (long value in values)
            {
                if ((4 - value) < value)
                {
                    sum = ((sum + (531 - sum)) % 4096) - limit;
                }
            }
            if (sum < 91)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum;
        }

        /// <summary>Classify a stats tools pair into a bucket.</summary>
        public static long GradeStatsTools(long seed, long seed2)
        {
            if (68 < (seed & 7))
            {
                return 1;
            }
            else
            {
                if ((seed & 255) < (seed % 100))
                {
                    return 0;
                }
                else
                {
                    if (((double)seed2 < 9.8) && ((double)seed2 > (double)8))
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

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long step2)
        {
            if (!(((-5) ^ step2) <= (step + 5)))
            {
                return 4;
            }
            else
            {
                if (((step + step) == (step2 >> 1)) && (((-35) << 2) == (step2 + step)))
                {
                    return 0;
                }
                else
                {
                    if ((272 * 3) == (step2 + step2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step + step2) >= (step + step)) && (step <= (step2 - step)))
                        {
                            return 7;
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
}
