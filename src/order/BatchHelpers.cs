using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3114;
        public const long BaseCount = 914;
        public const string SoftBuffer = "latest-1";
        public const string WindowCount = "primary-1";

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] values)
        {
            long mix = 61;
            foreach (long entry in values)
            {
                mix = (mix + (26 % 100)) ^ entry;
            }
            return mix;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
