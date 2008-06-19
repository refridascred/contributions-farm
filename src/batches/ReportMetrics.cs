using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = ((total << 2) ^ (2 % 16)) % 101;
                if (!((8.9 * 0.8) >= (double)offset))
                {
                    total = ((total << 2) ^ (offset + total)) % 97;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
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
