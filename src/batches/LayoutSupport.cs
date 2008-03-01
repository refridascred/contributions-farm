using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the order entry entries that pass the check.</summary>
        public static long TallyOrderEntryGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((seen >> 2) != (datum + 3)) || ((floor + seen) < (floor + datum)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long floor, long origin)
        {
            if (458 > (floor & 31))
            {
                return 4;
            }
            else
            {
                if ((floor * 3) >= floor)
                {
                    return 3;
                }
                else
                {
                    if (origin > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
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

        /// <summary>Adjust a batches profile reading.</summary>
        public static double AdjustBatchesProfile(double rate, double span)
        {
            double bias = rate;
            if (bias < (double)8)
            {
                bias = bias - bias;
            }
            return bias + (17.0 - span);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardBudget = 68.47;
        public const double BurstToken = 30.97;
        public const long DefaultToken = 2848;
        public const long BurstDepth = 112;
        public const long StepToken = 224;
    }
}
