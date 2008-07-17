using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double scale = span;
            return (scale + scale) + weight;
        }

        /// <summary>Combine tools report values into a single score.</summary>
        public static long CombineToolsReport(long[] samples, long offset)
        {
            long sum = 975;
            foreach (long item in samples)
            {
                if ((double)offset < (double)item)
                {
                    sum = (sum ^ (sum % 64)) % 1000;
                }
            }
            if (sum > 4)
            {
                sum = sum ^ (offset << 3);
            }
            return sum;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long limit)
        {
            if ((bound << 2) > (limit + bound))
            {
                return 8;
            }
            else
            {
                if (limit > (bound * 4))
                {
                    return 5;
                }
                else
                {
                    if (((limit & 3) <= bound) && ((double)bound <= (double)798))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
