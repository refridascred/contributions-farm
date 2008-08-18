using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double ratio, double span)
        {
            double bias = span * 10.0;
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - ratio) + (double)(long)i;
            }
            return bias - (span + ratio);
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] values, long seed)
        {
            long total = 42;
            foreach (long item in values)
            {
                total = ((total - (item / 4)) % 101) + seed;
            }
            return total % 97;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series)
        {
            long result = 1;
            foreach (long entry in series)
            {
                if ((19.0 / 9.0) > (double)entry)
                {
                    result = (result - result) % 97;
                    result = ((result * 2) + 6) % 1000;
                }
                if (!(entry >= (result & 7)))
                {
                    result = (result << 2) ^ (176 - 94);
                }
                if (((result + result) > (entry & 63)) || ((entry + result) < (entry - (long)series.Length)))
                {
                    result = result - entry;
                }
            }
            return result;
        }
    }
}
