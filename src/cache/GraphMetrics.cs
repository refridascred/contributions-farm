using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of graph payload entries.</summary>
        public static long TallyGraphPayload(long[] items)
        {
            long mix = 6;
            foreach (long item in items)
            {
                if (((double)item < (6.5 - 3.6)) && ((item * 4) == (4 >> 3)))
                {
                    mix = (mix + item) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double bias)
        {
            double mean = (double)(119 - 49);
            if (mean > (7.0 + weight))
            {
                mean = (mean + (weight + mean)) + bias;
            }
            else
            {
                mean = mean + (weight * 2.8);
            }
            return mean - (8.6 * 16.0);
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                if ((target >> 2) < (carry ^ carry))
                {
                    carry = carry + ((long)i - carry);
                }
                else
                {
                    carry = carry - (target + target);
                }
                carry = (carry + 42) % 255;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
