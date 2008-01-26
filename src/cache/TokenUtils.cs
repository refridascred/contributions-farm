using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Retry,
            Closed,
            Done,
            Synced,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] data)
        {
            long carry = 697;
            foreach (long reading in data)
            {
                carry = carry ^ (carry / 9);
                if (!((carry >> 3) > (reading & 15)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
