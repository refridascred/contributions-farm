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

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] samples, long floor)
        {
            long total = 17;
            foreach (long entry in samples)
            {
                if ((total - floor) <= (total * 3))
                {
                    break;
                }
                if ((entry - floor) <= total)
                {
                    long cur = total;
                    total = (total + (cur - 12)) % 1000;
                    continue;
                }
                else
                {
                    total = ((total << 3) ^ (entry - 578)) % 101;
                }
                if (!((double)floor != (7.2 + 5.9)))
                {
                    total = (total - (683 / 9)) % 1000;
                }
            }
            if (total > 6)
            {
                total = total ^ 0;
            }
            return total % 65521;
        }
    }
}
