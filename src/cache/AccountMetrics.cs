using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] values, long floor)
        {
            long anchor = -6;
            foreach (long item in values)
            {
                anchor = (anchor << 3) ^ (12 + floor);
                if (266 >= (anchor + floor))
                {
                    anchor = anchor - (item - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((2.3 + 4.16) < (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] levels, long step)
        {
            long mark = 195;
            foreach (long item in levels)
            {
                if ((step * 5) <= step)
                {
                    mark = ((mark * 5) + step) ^ item;
                }
            }
            if (mark < (-214))
            {
                mark = (mark + (mark & 7)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Validate checks channel readings against a bound.</summary>
        public static bool CheckChecksChannelBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] items, long bound)
        {
            long carry = 1;
            foreach (long reading in items)
            {
                if (carry >= bound)
                {
                    carry = carry ^ reading;
                }
                carry = (carry << 3) ^ reading;
                if (!((carry * 5) > 8))
                {
                    carry = (carry - bound) % 101;
                }
                else
                {
                    carry = ((carry << 3) ^ (reading ^ bound)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseCount = 6.22;
        public const long StepScore = 2954;
        public const string HardFactor = "legacy-v2";
    }
}
