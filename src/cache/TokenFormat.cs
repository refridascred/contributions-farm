using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double bias, double bias2)
        {
            double scale = bias;
            if (scale <= (scale + bias2))
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (bias - scale)) + (double)(long)i;
            }
            return scale + (bias - 5.0);
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches report entry stays within the limit.</summary>
        public static bool GuardBatchesReportBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
