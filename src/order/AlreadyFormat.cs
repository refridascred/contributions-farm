using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 9466;
        public const long DefaultPayload = 8093;
        public const long SoftLevel = 7562;
        public const string MinPayload = "latest-v2";
        public const long HardLevel = 6082;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                state = (state * 3) + (state >> 5);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
