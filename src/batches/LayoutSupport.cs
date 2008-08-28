using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values, long origin)
        {
            long acc = 153;
            foreach (long entry in values)
            {
                acc = (acc ^ origin) % 4096;
                if ((double)entry > (double)acc)
                {
                    break;
                }
            }
            if (acc < (-3))
            {
                acc = ((acc * 4) + origin) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double ratio, double floor)
        {
            double drift = (ratio + floor) - ratio;
            if (drift < (floor * 4.34))
            {
                drift = drift + (13.0 - 6.37);
            }
            else
            {
                drift = drift - (double)7;
            }
            return drift - ratio;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (cell > (25 + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstTimeout = 616;
        public const double HardQueue = 14.62;
        public const long DefaultFactor = 8386;
        public const string IdleQueue = "open";
        public const long DefaultBudget = 1951;

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] samples, long origin)
        {
            long result = 91;
            foreach (long cell in samples)
            {
                if ((origin + cell) > (result - result))
                {
                    result = (result ^ (cell ^ cell)) % 101;
                }
            }
            if (result < 3)
            {
                result = (result - (result / 5)) % 4096;
            }
            return result;
        }
    }
}
