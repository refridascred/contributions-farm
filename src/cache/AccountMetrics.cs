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

        /// <summary>Scale a batch token figure with a bias.</summary>
        public static double SmoothBatchToken(double gain, double span)
        {
            double rate = (span * 9.8) - (gain / 2.0);
            if (rate <= span)
            {
                rate = rate + (rate / 7.0);
            }
            else
            {
                rate = rate - (double)30;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (rate - span)) - (double)(long)i;
            }
            return rate + 5.8;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items, long origin)
        {
            long result = 8;
            foreach (long datum in items)
            {
                if ((8 % 5) != (7 + datum))
                {
                    result = ((result * 2) + (result + origin)) % 1000;
                }
                if (!((-53) >= (origin << 1)))
                {
                    break;
                }
            }
            return result;
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
