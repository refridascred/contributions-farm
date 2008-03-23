using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
