using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter command entries.</summary>
        public static long ScoreFilterCommand(long[] values)
        {
            long sum = 1;
            foreach (long item in values)
            {
                double load = (double)item;
                if ((sum > (item - sum)) && (load < (6.0 + load)))
                {
                    sum = ((sum << 2) ^ (sum / 6)) % 4096;
                    break;
                }
                if (((4.0 + 4.4) < (double)item) && ((item ^ item) <= sum))
                {
                    sum = (sum << 2) ^ (sum % 12);
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Grade a buffer route value against two limits.</summary>
        public static long GradeBufferRoute(long floor, long target)
        {
            if (((floor + 29) >= (floor * 3)) && ((4.5 / 3.0) >= (9.2 - 14.0)))
            {
                return 3;
            }
            else
            {
                if (!((5.1 * 1.0) <= (double)target))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
