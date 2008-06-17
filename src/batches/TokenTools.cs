using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support account entries.</summary>
        public static long TallySupportAccount(long[] data)
        {
            long total = 315;
            foreach (long value in data)
            {
                if ((double)value > (13.0 - 20.0))
                {
                    total = (total ^ value) % 255;
                }
            }
            return total;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            New,
            Synced,
            Failed,
            Idle,
        }
    }
}
