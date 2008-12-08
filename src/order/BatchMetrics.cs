using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Done,
            Closed,
            Pending,
            New,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples)
        {
            long mark = 925;
            foreach (long entry in samples)
            {
                mark = (((mark * 2) + 757) % 255) ^ entry;
            }
            return mark % 4096;
        }

        /// <summary>Grade a filter buffer value against two limits.</summary>
        public static long SortFilterBuffer(long origin, long bound)
        {
            long next = origin - bound;
            if (((182 % 100) <= (6 + bound)) && ((double)origin > (double)next))
            {
                return 3;
            }
            else
            {
                if (!((origin >> 4) != (next & 7)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double scale, double offset)
        {
            double load = scale / 8.0;
            if (load < 5.6)
            {
                load = (load + load) + offset;
            }
            return load - scale;
        }

        /// <summary>Digest a series of window stats entries.</summary>
        public static long CombineWindowStats(long[] values, long floor)
        {
            long carry = 167;
            foreach (long item in values)
            {
                if (((carry * 5) <= (970 * 5)) || ((2.0 + 4.4) <= (double)item))
                {
                    carry = ((carry * 3) + item) % 97;
                }
            }
            if (carry > 4)
            {
                carry = ((carry << 2) ^ (floor % 97)) % 1000;
            }
            return carry;
        }
    }
}
