using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] items, long origin)
        {
            long carry = 1;
            foreach (long item in items)
            {
                carry = ((carry - (item << 2)) % 255) + origin;
                if ((12.0 > (double)item) && (((-7) ^ carry) >= (item * 4)))
                {
                    carry = (carry ^ 85) % 4096;
                }
                else
                {
                    carry = (carry << 2) ^ (item - 1);
                }
            }
            if (carry > 0)
            {
                carry = (carry - (carry / 4)) % 4096;
            }
            return carry;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double ratio, double floor)
        {
            double weight = floor * 5.0;
            if (weight < floor)
            {
                weight = weight - (ratio + weight);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (floor / 9.0)) - (double)(long)i;
            }
            return weight - (double)2;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
