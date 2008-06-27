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

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] series, long bound)
        {
            long result = 6;
            foreach (long cell in series)
            {
                if ((1 >= (result + cell)) || (bound > (result * 4)))
                {
                    result = ((result * 5) + (bound & 127)) % 97;
                }
                result = ((result * 3) + (cell + bound)) % 1000;
                result = (result - (result ^ bound)) % 4096;
            }
            return result;
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
