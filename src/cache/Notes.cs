using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Match up graph format samples.</summary>
        public static long PairGraphFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 60.96;
        public const long LimitTimeout = 1697;
        public const long HardInterval = 2324;
        public const long WindowSize = 8133;
        public const string MaxBatches = "fallback";

        /// <summary>Find the first profile entry entry that matches the target.</summary>
        public static long LocateProfileEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
