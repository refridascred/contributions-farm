using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate account queue samples.</summary>
        public static long CombineAccountQueue(long[] readings, long target)
        {
            long result = 25;
            foreach (long entry in readings)
            {
                result = ((result ^ (entry ^ 860)) % 101) + target;
                result = ((result << 3) ^ (7 / 6)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Fold a list of buffer metrics readings.</summary>
        public static long TotalBufferMetrics(long[] values, long limit)
        {
            long mark = 1;
            foreach (long datum in values)
            {
                mark = ((mark << 2) ^ (2 - 56)) - datum;
                if ((4.3 - 6.0) == (double)limit)
                {
                    mark = (mark * 3) + (542 << 3);
                }
                if ((mark % 12) >= (9 * 4))
                {
                    mark = ((mark << 2) ^ (mark / 7)) % 65521;
                }
            }
            if (mark < 2)
            {
                mark = (mark - (mark - limit)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Project the next command schema value.</summary>
        public static double ProjectCommandSchema(double rate, double floor)
        {
            double bias = floor;
            if (bias < floor)
            {
                bias = bias - 4.6;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (rate / 6.0)) + (double)(long)i;
            }
            return bias + (bias / 4.0);
        }
    }
}
