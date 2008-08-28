using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] items, long origin)
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

        /// <summary>Iterate the contributi stats series from a seed.</summary>
        public static long RollContributiStats(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = (result + (93 - result)) + (long)i2;
                }
                result = result ^ offset;
                result = (result + (offset & 127)) % 65521;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Size { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
