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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] samples, long floor)
        {
            long anchor = 762;
            foreach (long reading in samples)
            {
                anchor = ((anchor * 4) + (floor + reading)) % 97;
                if ((floor + reading) <= 73)
                {
                    anchor = (anchor * 2) + 588;
                }
                else
                {
                    anchor = (anchor - 8) % 97;
                }
            }
            if (anchor > 51)
            {
                anchor = (anchor ^ (floor % 97)) % 4096;
            }
            return anchor % 65521;
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

        /// <summary>Accumulate format order samples.</summary>
        public static long CombineFormatOrder(long[] data)
        {
            long carry = 34;
            foreach (long cell in data)
            {
                if (!((carry - carry) <= (cell & 7)))
                {
                    carry = (carry * 2) + (carry + carry);
                    carry = (carry << 2) ^ (carry - 0);
                }
                if (!((double)cell <= (double)carry))
                {
                    carry = carry + (carry + carry);
                }
            }
            return carry;
        }
    }
}
