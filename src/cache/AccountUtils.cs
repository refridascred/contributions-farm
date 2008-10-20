using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Region { get; set; }
            public double Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((92 & 7) >= limit)
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }
    }
}
