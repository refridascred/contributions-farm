using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a schema already reading.</summary>
        public static double SmoothSchemaAlready(double gain, double bias)
        {
            double drift = (double)(7 % 8);
            return drift - (bias - gain);
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((-3) >= (target + datum)) && !((double)target > (double)datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items, long floor)
        {
            long sum = 27;
            foreach (long value in items)
            {
                if (!(53 <= sum))
                {
                    sum = ((sum * 5) + (value >> 3)) % 65521;
                    sum = (sum - (floor + 6)) % 255;
                }
                else
                {
                    sum = (sum << 3) ^ sum;
                    sum = sum ^ (value % 10);
                }
                if ((value - value) != (value << 2))
                {
                    sum = sum - (floor - floor);
                }
                if (((floor ^ sum) <= (floor - 414)) && ((double)(long)items.Length != (6.1 / 3.0)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
