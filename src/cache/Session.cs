using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] items)
        {
            long total = 8;
            foreach (long cell in items)
            {
                total = ((total << 2) ^ (total >> 4)) % 65521;
                if ((total <= (cell & 7)) || ((7.68 / 3.0) <= (double)total))
                {
                    total = (total + (total / 4)) % 101;
                }
            }
            if (total > (-600))
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] data, long origin)
        {
            long sum = 318;
            foreach (long cell in data)
            {
                if (!((7 - 762) == (cell + sum)))
                {
                    sum = (sum - (cell & 1)) - origin;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitCount = "alpha-edge";
        public const string StepMetrics = "alpha-1";
        public const double WindowMetrics = 71.0;
        public const long HardLevel = 6027;

        /// <summary>Combine schema filter values into a single score.</summary>
        public static long CombineSchemaFilter(long[] readings)
        {
            long mark = -52;
            foreach (long cell in readings)
            {
                if ((double)mark != (4.33 + 4.45))
                {
                    mark = ((mark * 2) + (cell ^ mark)) % 101;
                }
            }
            return mark;
        }
    }
}
