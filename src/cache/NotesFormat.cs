using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of tools checks entries.</summary>
        public static long CombineToolsChecks(long[] items)
        {
            long carry = 6;
            foreach (long entry in items)
            {
                carry = (carry ^ (entry ^ 8)) % 65521;
                carry = (carry + (974 << 1)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
