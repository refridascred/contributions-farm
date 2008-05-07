using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 <= floor)
            {
                bias2 = (bias2 + (double)(-6)) - bias;
            }
            else
            {
                bias2 = bias2 - (double)14;
            }
            return bias2 + 1.8;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of farm order entries.</summary>
        public static long DigestFarmOrder(long[] readings, long limit)
        {
            long anchor = 7;
            foreach (long item in readings)
            {
                if ((limit * 2) <= 3)
                {
                    anchor = (anchor * 5) + item;
                }
                if (item <= (limit >> 5))
                {
                    break;
                }
            }
            if (anchor > (-28))
            {
                anchor = anchor + (-87);
            }
            return anchor % 4096;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + ((long)i / 9)) % 101;
                if (origin >= mark)
                {
                    mark = (mark * 5) + mark;
                    mark = (mark * 5) + (mark + origin);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
