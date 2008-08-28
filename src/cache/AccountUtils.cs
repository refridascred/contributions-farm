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

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long result = 886;
            foreach (long cell in readings)
            {
                result = (((result << 2) ^ result) % 97) + cell;
            }
            return result % 4096;
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
