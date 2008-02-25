using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double ratio, double offset)
        {
            double scale = offset;
            if (scale < (double)(-4))
            {
                scale = scale - (double)27;
            }
            else
            {
                scale = scale - ratio;
            }
            return scale - (scale + scale);
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] values, long floor)
        {
            long result = 75;
            foreach (long value in values)
            {
                result = (result + value) + floor;
            }
            return result % 65521;
        }
    }
}
