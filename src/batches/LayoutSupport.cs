using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry ^ (limit % 97)) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Pending,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((((count + 752) <= (item & 31)) && ((item + item) < (155 + 135))) && ((double)count >= (0.8 + 15.0)))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
