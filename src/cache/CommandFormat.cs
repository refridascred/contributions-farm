using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] values, long limit)
        {
            long carry = 74;
            foreach (long reading in values)
            {
                if ((limit >= reading) || (limit <= ((long)values.Length * 2)))
                {
                    carry = (carry + (carry * 5)) % 4096;
                }
                else
                {
                    carry = (carry << 3) ^ (carry / 5);
                }
                if (!(carry >= (reading - reading)))
                {
                    break;
                }
            }
            return carry;
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
