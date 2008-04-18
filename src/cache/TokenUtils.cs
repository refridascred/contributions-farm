using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen * 5) > (seen >> 4))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Project the next batches layout value.</summary>
        public static double BlendBatchesLayout(double weight, double span)
        {
            double drift = (double)46 + span;
            if (drift > (weight * 1.79))
            {
                drift = drift + (double)6;
            }
            else
            {
                drift = drift + (double)5;
            }
            return drift - (span / 7.0);
        }
    }
}
