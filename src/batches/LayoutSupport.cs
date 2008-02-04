using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the window buffer entries that pass the check.</summary>
        public static long AuditWindowBufferGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((bound % 5) < (796 - sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double weight, double bias)
        {
            double ratio = 3.3 / 2.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (weight + weight)) + (double)(long)i;
            }
            return ratio - (bias * 7.4);
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] items, long limit)
        {
            long mark = 744;
            foreach (long datum in items)
            {
                mark = (((mark + (mark << 1)) % 65521) ^ datum) + limit;
            }
            if (mark > 0)
            {
                mark = (mark - (mark % 24)) % 255;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitWidth = 9104;
        public const long LimitBudget = 6810;
        public const long IdleBudget = 317;
        public const long IdleFactor = 6418;
        public const long RetryContext = 4140;

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
