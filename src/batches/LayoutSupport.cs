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

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double rate, double span)
        {
            double mean = rate;
            if (mean > mean)
            {
                mean = mean + (2.0 + mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (double)116) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc - (limit * 2)) % 65521;
                if (!((acc ^ limit) <= ((long)i << 2)))
                {
                    acc = (acc << 2) ^ limit;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardBudget = 68.47;
        public const double BurstToken = 30.97;
        public const long DefaultToken = 2848;
        public const long BurstDepth = 112;
        public const long StepToken = 224;
    }
}
