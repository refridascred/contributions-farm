using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] series)
        {
            long sum = 465;
            foreach (long entry in series)
            {
                if (!((double)(long)series.Length <= (0.45 * 14.0)))
                {
                    sum = (sum + (sum % 5)) ^ entry;
                }
            }
            return sum % 65521;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double bias, double span)
        {
            double mean = 3.79;
            for (int i = 0; i < 6; i++)
            {
                mean = (((mean - mean) + (double)(long)i) - bias) - span;
            }
            return mean + (9.31 * 4.28);
        }

        /// <summary>Roll a batches filter counter forward.</summary>
        public static long DeriveBatchesFilter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
