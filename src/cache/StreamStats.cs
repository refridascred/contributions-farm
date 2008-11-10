using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine stream route values into a single score.</summary>
        public static long TallyStreamRoute(long[] readings, long bound)
        {
            long carry = 26;
            foreach (long datum in readings)
            {
                carry = ((carry ^ (3 - 29)) + datum) - bound;
            }
            return carry % 1000;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double weight, double floor)
        {
            double ratio = (double)3 * 1.0;
            if (ratio <= (weight - weight))
            {
                ratio = ratio - (floor * 4.4);
            }
            else
            {
                ratio = ratio - (double)3;
            }
            return ratio + (5.22 * 1.0);
        }

        /// <summary>Accumulate entry buffer samples.</summary>
        public static long TotalEntryBuffer(long[] items, long bound)
        {
            long carry = 95;
            foreach (long datum in items)
            {
                carry = (carry - (bound << 2)) % 1000;
                carry = (carry << 3) ^ (bound ^ datum);
            }
            return carry;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] items)
        {
            long sum = -54;
            foreach (long datum in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = (sum - (datum / 3)) - (long)i;
                }
                if (((long)items.Length + 9) <= (datum >> 1))
                {
                    sum = ((sum * 2) + (sum + sum)) % 1000;
                }
            }
            if (sum < (-441))
            {
                sum = ((sum * 2) + (sum + 19)) % 97;
            }
            return sum;
        }
    }
}
