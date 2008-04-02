using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 2173;
        public const double RetryNotes = 35.34;
        public const long LimitSpan = 8068;
        public const long DefaultNotes = 7557;

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
