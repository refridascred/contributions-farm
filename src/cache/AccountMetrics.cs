using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many payload token samples are out of range.</summary>
        public static long AuditPayloadTokenMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((4 + (long)items.Length) >= (seen * 2))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double weight, double floor)
        {
            double ratio = (double)(11 >> 1);
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - (weight - 0.4)) + (double)(long)i) + floor;
            }
            return ratio + weight;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)offset != (1.0 + 5.44))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long bound, long bound2)
        {
            if ((bound + bound2) <= bound)
            {
                return 1;
            }
            else
            {
                if ((double)bound2 != (16.0 + 0.75))
                {
                    return 0;
                }
                else
                {
                    if (((6.37 + 8.15) <= (double)bound) || (bound > 42))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
