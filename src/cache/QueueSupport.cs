using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 925;
        public const long CacheRatio = 9718;
        public const long WindowWidth = 8348;
        public const long BatchSize = 4362;
        public const long BatchRecord = 3040;

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
