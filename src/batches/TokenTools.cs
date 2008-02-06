using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Draft,
            Done,
            Stale,
            New,
            Retry,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] values, long target)
        {
            long carry = 88;
            foreach (long reading in values)
            {
                carry = (carry ^ (target & 15)) - reading;
            }
            return carry % 1000;
        }
    }
}
