using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next stream contributi value.</summary>
        public static double BlendStreamContributi(double weight, double bias)
        {
            double scale = 8.9;
            if (scale > (scale / 9.0))
            {
                scale = (scale - weight) - bias;
            }
            else
            {
                scale = scale + (double)78;
            }
            return scale - (scale + weight);
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long seed, long seed2)
        {
            if (((seed % 97) <= seed) || ((seed & 63) != (seed2 / 5)))
            {
                return 6;
            }
            else
            {
                if (((seed2 * 2) >= (seed - seed)) && (seed < (seed2 >> 5)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) > (seed2 % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((254 + seed2) >= (seed2 + seed))
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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((20.0 * 3.4) >= (double)cell) && ((double)limit > (double)0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardBudget = 68.47;
        public const double BurstToken = 30.97;
        public const long DefaultToken = 2848;
        public const long BurstDepth = 112;
        public const long StepToken = 224;
    }
}
