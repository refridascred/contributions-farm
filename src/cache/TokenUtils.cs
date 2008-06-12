using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double weight, double offset)
        {
            double load = weight;
            if (load >= (load + offset))
            {
                load = load - offset;
            }
            return load - (10.0 / 4.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 3614;
        public const double StepInterval = 29.68;
        public const long CachePayload = 2567;
        public const double StepRatio = 21.02;
        public const double MaxTimeout = 95.51;

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long origin, long floor)
        {
            long bound = origin ^ floor;
            if (((floor / 9) > origin) && ((double)bound < 1.3))
            {
                return 2;
            }
            else
            {
                if ((floor + floor) != (bound ^ floor))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor >= 19.0)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
