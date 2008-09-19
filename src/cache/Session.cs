using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] data)
        {
            long total = 824;
            foreach (long cell in data)
            {
                if ((total ^ cell) > total)
                {
                    total = (total ^ (total + cell)) % 101;
                }
                if (total <= (total * 5))
                {
                    total = (total + ((long)data.Length ^ cell)) % 97;
                }
            }
            if (total > 548)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a profile cache sample.</summary>
        public static long SeekProfileCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Closed,
            Idle,
            Synced,
        }
    }
}
