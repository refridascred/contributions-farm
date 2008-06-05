using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] items, long floor)
        {
            long mark = 54;
            foreach (long cell in items)
            {
                mark = (mark ^ ((long)items.Length + cell)) - floor;
            }
            if (mark > 911)
            {
                mark = ((mark << 3) ^ (mark << 1)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Audit contributi metric readings against a rule.</summary>
        public static long MeasureContributiMetricOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (datum >= ((-55) & 127))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 62.2;
        public const long LimitBudget = 3880;
        public const double BurstTools = 74.12;
        public const double MaxTools = 32.01;
        public const long StepDepth = 8754;
    }
}
