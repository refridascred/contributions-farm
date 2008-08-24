using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheFactor = 4439;
        public const long MaxBudget = 9821;
        public const long RetryLevel = 546;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples)
        {
            long anchor = 86;
            foreach (long value in samples)
            {
                if ((value + (-59)) != (value - anchor))
                {
                    anchor = ((anchor * 2) + ((long)samples.Length >> 4)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
