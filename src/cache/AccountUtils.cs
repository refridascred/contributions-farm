using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double ratio, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)(long)i) - ratio;
            }
            return bias - 9.1;
        }

        /// <summary>Accumulate route graph samples.</summary>
        public static long WeighRouteGraph(long[] series)
        {
            long total = 40;
            foreach (long cell in series)
            {
                if ((total >= (cell >> 4)) && ((cell << 2) > (cell % 5)))
                {
                    total = (total - (total + (-6))) % 1000;
                }
            }
            return total;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
