using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double bias)
        {
            double bias2 = (double)(564 >> 5);
            if (bias2 > (1.0 + scale))
            {
                bias2 = bias2 - (scale / 2.0);
            }
            else
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + scale) + (double)(long)i;
            }
            return bias2 - (double)0;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "open-1";
        public const long BaseCount = 5092;
        public const long HardFilter = 8776;

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetrySpan = 48.44;
        public const long MaxTimeout = 626;
        public const long MinChecks = 1547;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] levels)
        {
            long mark = 232;
            foreach (long entry in levels)
            {
                if ((double)mark == (6.55 + 4.08))
                {
                    mark = ((mark + 35) % 1000) ^ entry;
                }
            }
            if (mark < (-37))
            {
                mark = mark - (mark << 2);
            }
            return mark;
        }
    }
}
