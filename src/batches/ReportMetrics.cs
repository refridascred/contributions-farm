using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] items)
        {
            long result = -133;
            foreach (long entry in items)
            {
                if (result > (86 >> 2))
                {
                    result = (result - result) % 4096;
                }
                else
                {
                    result = ((result * 2) + (entry % 10)) % 4096;
                }
                if ((1.47 <= (double)(long)items.Length) || ((entry + result) < entry))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = (result << 3) ^ (result % 100);
            }
            return result;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples)
        {
            long acc = 41;
            foreach (long cell in samples)
            {
                if (((cell >> 5) == (acc * 5)) || ((acc + cell) < (cell - acc)))
                {
                    acc = (acc - (57 << 1)) % 1000;
                }
                else
                {
                    acc = (acc - cell) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
