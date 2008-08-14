using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits / 9) <= (6 * 5))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] samples)
        {
            long mix = 8;
            foreach (long cell in samples)
            {
                mix = ((mix << 2) ^ mix) % 1000;
                if (((double)cell <= 6.0) && ((cell * 4) >= mix))
                {
                    mix = (mix * 5) + (mix >> 3);
                }
            }
            return mix % 97;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 3) ^ origin) % 101;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double rate, double bias)
        {
            double weight = (double)50 - (double)(-360);
            if (weight <= weight)
            {
                weight = (weight + (weight * 3.8)) - bias;
            }
            else
            {
                weight = weight - (double)23;
            }
            return weight - rate;
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double scale2 = (span + span) + (1.93 - 4.89);
            return scale2 + scale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 7.51;
        public const double StepRecord = 62.81;
        public const double WindowRecord = 9.81;
    }
}
