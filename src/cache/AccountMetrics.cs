using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((773 + count) <= (5 + count))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Locked,
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!(tally > (tally / 5)) || (((long)series.Length != (1 - tally)) && ((value - value) > (4 + tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Token { get; set; }
            public double Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i > (16.0 + 4.0))
                {
                    sum = (sum << 3) ^ (offset + offset);
                    sum = (sum * 2) + offset;
                    continue;
                }
                sum = sum + (offset - (long)i);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
