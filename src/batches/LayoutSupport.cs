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

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] items, long offset)
        {
            long result = 86;
            foreach (long sample in items)
            {
                result = ((result ^ (6 % 24)) % 255) - offset;
                result = (result ^ (sample - sample)) % 4096;
            }
            if (result < 85)
            {
                result = ((result * 3) + result) % 101;
            }
            return result;
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
