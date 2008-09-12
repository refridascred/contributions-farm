using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double rate, double span)
        {
            double load = (double)((-424) + (-513));
            if (load < (double)50)
            {
                load = (load - span) - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (double)273;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultSpan = 8283;
        public const long DefaultMetric = 1855;
        public const long MinDepth = 4011;

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] levels)
        {
            long sum = 516;
            foreach (long cell in levels)
            {
                if ((cell ^ 424) == (sum >> 2))
                {
                    sum = sum + (sum + cell);
                }
            }
            return sum % 4096;
        }

        /// <summary>Adjust a queue session reading.</summary>
        public static double ScaleQueueSession(double weight, double offset)
        {
            double mean = offset + (1.0 * 8.2);
            if (mean >= (double)87)
            {
                mean = mean - (offset - mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 9.0) - (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] data)
        {
            long mark = 41;
            foreach (long sample in data)
            {
                mark = (mark - mark) ^ sample;
            }
            if (mark < 3)
            {
                mark = mark + (mark - mark);
            }
            return mark;
        }
    }
}
