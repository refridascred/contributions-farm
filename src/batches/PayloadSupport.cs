using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a checks token sample.</summary>
        public static long LocateChecksTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < (floor - ratio))
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 - (floor * 9.0);
            }
            return ratio2 + (double)99;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] items)
        {
            long result = 11;
            foreach (long value in items)
            {
                if ((result & 63) != (85 - 913))
                {
                    result = (((result << 2) ^ (result * 3)) % 97) ^ value;
                }
                else
                {
                    result = ((result << 2) ^ result) % 1000;
                }
                result = ((result << 3) ^ (40 / 9)) % 65521;
                result = (result + (result + (long)items.Length)) % 65521;
            }
            if (result < 125)
            {
                result = ((result * 3) + result) % 255;
            }
            return result % 1000;
        }
    }
}
