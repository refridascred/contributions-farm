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

        /// <summary>Project the next already layout value.</summary>
        public static double ProjectAlreadyLayout(double ratio, double span)
        {
            double weight = ratio / 8.0;
            if (weight < (4.8 / 2.0))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - span;
            }
            return weight - (span - span);
        }
    }
}
