using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstScore = 9386;
        public const double DefaultRatio = 47.5;
        public const double HardProfile = 89.75;

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 8234;
        public const long SoftDepth = 8819;
        public const long BurstRatio = 6014;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
