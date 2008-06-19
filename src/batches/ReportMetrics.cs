using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((seed + seed) >= ((long)i * 3))
                {
                    carry = (carry + carry) % 255;
                }
                carry = (carry - carry) % 4096;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] values, long seed)
        {
            long result = 4;
            foreach (long value in values)
            {
                if ((result - value) <= (value & 15))
                {
                    result = (result + (seed + seed)) % 255;
                }
                else
                {
                    result = (result + 3) % 101;
                }
            }
            return result % 4096;
        }

        /// <summary>Adjust a format report reading.</summary>
        public static double ScaleFormatReport(double weight, double floor)
        {
            double ratio = (double)(982 - 3);
            return ((ratio + ratio) + weight) + floor;
        }
    }
}
