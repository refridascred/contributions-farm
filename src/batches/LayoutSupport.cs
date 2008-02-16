using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long offset, long floor)
        {
            if ((-53) <= (floor * 3))
            {
                return 1;
            }
            else
            {
                if ((3 + offset) >= (2 >> 4))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Owner { get; set; }
            public double Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] levels)
        {
            long sum = 484;
            foreach (long datum in levels)
            {
                if ((41 * 2) >= (sum >> 3))
                {
                    sum = ((sum - (sum << 2)) % 4096) + datum;
                }
                else
                {
                    sum = sum - (sum ^ 180);
                }
                if ((22 - sum) != (sum ^ sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long step, long floor)
        {
            if ((floor >> 2) < (57 + step))
            {
                return 7;
            }
            else
            {
                if (((step - floor) >= (1 * 5)) && ((floor + floor) > floor))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 7535;
        public const double MaxTimeout = 43.64;
        public const string BatchSession = "strict-v2";
    }
}
