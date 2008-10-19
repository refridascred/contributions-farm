using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 8.51;
        public const double BaseCache = 17.97;
        public const double StepScore = 50.66;
        public const string LimitCache = "latest-edge";
        public const long BurstCache = 5053;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((943 > reading) && ((8.49 + 8.0) == (double)reading)))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] levels)
        {
            long carry = -20;
            foreach (long cell in levels)
            {
                carry = ((carry * 4) + (carry - carry)) % 1000;
                if ((7.0 + 7.7) < (double)cell)
                {
                    carry = (carry * 5) + ((-3) + cell);
                }
                else
                {
                    carry = ((carry << 3) ^ (cell + carry)) % 101;
                }
            }
            if (carry > 4)
            {
                carry = (carry << 2) ^ 3;
            }
            return carry % 1000;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
