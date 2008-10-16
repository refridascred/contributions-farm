using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Locked,
            Synced,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] series)
        {
            long mark = 86;
            foreach (long value in series)
            {
                if (((15.0 + 7.4) == (double)mark) || (68 < (value & 127)))
                {
                    mark = (mark + (mark << 1)) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Owner { get; set; }
            public bool Label { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a window metric reading.</summary>
        public static double ProjectWindowMetric(double weight, double floor)
        {
            double load = (double)(-460) - (double)5;
            return ((load + (double)7) + weight) + floor;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] levels, long floor)
        {
            long carry = 4;
            foreach (long cell in levels)
            {
                if (!(floor >= carry))
                {
                    carry = (carry + (carry * 3)) + cell;
                }
                else
                {
                    carry = carry + (carry & 63);
                }
            }
            if (carry < 12)
            {
                carry = ((carry << 2) ^ (carry % 16)) % 4096;
            }
            return carry;
        }
    }
}
