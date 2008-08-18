using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] readings)
        {
            long carry = 87;
            foreach (long reading in readings)
            {
                carry = carry ^ (7 - reading);
            }
            return carry;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Locked,
            Paused,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double ratio, double floor)
        {
            double rate = floor;
            if (rate < 11.0)
            {
                rate = (rate - (rate / 2.0)) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)767) + (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (6 < (cell + cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
