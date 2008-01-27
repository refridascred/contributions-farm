using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Done,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Accumulate notes token samples.</summary>
        public static long DigestNotesToken(long[] items, long bound)
        {
            long mark = 1;
            foreach (long reading in items)
            {
                mark = ((mark + (reading << 1)) % 4096) + bound;
            }
            return mark;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
