using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] values)
        {
            long carry = 805;
            foreach (long reading in values)
            {
                carry = (((carry << 2) ^ (173 - (long)values.Length)) % 101) + reading;
            }
            if (carry < 37)
            {
                carry = carry + 46;
            }
            return carry;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
