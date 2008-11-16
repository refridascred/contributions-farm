using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine farm batches values into a single score.</summary>
        public static long TotalFarmBatches(long[] data, long step)
        {
            long total = 67;
            foreach (long reading in data)
            {
                if (((total + total) <= step) && ((0.8 - 17.0) < (double)reading))
                {
                    total = ((total * 3) + total) % 65521;
                }
                else
                {
                    total = (total + (reading + total)) % 255;
                }
            }
            return total;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                if (limit > result)
                {
                    long delta = (92 / 8) - (74 % 12);
                    result = result - (delta - result);
                }
                if ((limit & 7) <= (result - (long)i))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Size { get; set; }
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] values, long target)
        {
            long acc = 2;
            foreach (long item in values)
            {
                if (target < item)
                {
                    acc = (acc * 4) + acc;
                }
                else
                {
                    acc = (acc << 3) ^ target;
                }
                acc = acc - ((-15) << 3);
                acc = acc ^ (acc + acc);
                if (((acc - acc) == (951 & 3)) && ((5.12 * 2.1) >= (double)item))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a filter entry reading.</summary>
        public static double SmoothFilterEntry(double bias, double offset)
        {
            double bias2 = (6.97 / 4.0) - (bias + bias);
            if (bias2 < (double)970)
            {
                bias2 = bias2 + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 + (double)332;
        }
    }
}
