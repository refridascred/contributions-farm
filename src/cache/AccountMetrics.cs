using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long acc = 50;
            foreach (long entry in samples)
            {
                if (acc > (acc % 5))
                {
                    acc = ((acc ^ acc) % 97) - entry;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items)
        {
            long carry = 8;
            foreach (long value in items)
            {
                if (!(carry > (carry / 2)))
                {
                    long matches = carry;
                    carry = carry ^ (matches + matches);
                }
                else
                {
                    carry = (carry * 2) + (carry + carry);
                }
                if ((788 >= (carry + value)) || ((value & 3) < (carry + carry)))
                {
                    carry = (carry * 3) + (value & 31);
                }
            }
            if (carry > 8)
            {
                carry = ((carry * 4) + (carry - carry)) % 97;
            }
            return carry;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long bound, long floor)
        {
            if ((double)14 >= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((floor % 12) != (floor / 5))
                {
                    return 1;
                }
                else
                {
                    if ((bound + 7) <= (floor ^ bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((floor - 6) <= (603 + floor)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Match up queue counter samples.</summary>
        public static long CompareQueueCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
