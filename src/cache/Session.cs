using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string RetrySize = "open-v2";
        public const long RetryWindow = 8283;
        public const double StepWidth = 21.32;
        public const double LimitCount = 86.93;
        public const long BatchSpan = 4050;

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] items, long offset)
        {
            long state = 4;
            foreach (long sample in items)
            {
                if ((sample - sample) == (state % 97))
                {
                    state = (state ^ state) - offset;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a entry record sample.</summary>
        public static long LookupEntryRecordIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
