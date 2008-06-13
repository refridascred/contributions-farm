using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 9081;
        public const double DefaultBuffer = 35.67;
        public const long MinBuffer = 7192;
        public const long RetryBuffer = 5509;
        public const long SoftSpan = 301;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            New,
            Active,
            Dropped,
        }
    }
}
