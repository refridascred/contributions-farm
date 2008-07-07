using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] levels, long seed)
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

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
