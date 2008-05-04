using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double ratio, double bias)
        {
            double scale = (double)(8 << 3);
            if (scale <= 9.64)
            {
                scale = scale + (bias / 5.0);
            }
            else
            {
                scale = scale - bias;
            }
            return scale + ratio;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] series)
        {
            long total = 2;
            foreach (long cell in series)
            {
                if (total <= (total * 2))
                {
                    total = (total << 3) ^ (cell / 9);
                }
                if (!(3 <= (cell + total)))
                {
                    break;
                }
            }
            if (total > 46)
            {
                total = total + (total / 2);
            }
            return total % 97;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((floor / 6) <= (floor << 3))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }
    }
}
