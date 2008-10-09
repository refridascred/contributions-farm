using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a booking summary.</summary>
        public sealed class BookingSummary
        {
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Rank already route input into a small class.</summary>
        public static long SortAlreadyRoute(long floor, long offset)
        {
            if ((floor + 0) == (offset & 15))
            {
                return 7;
            }
            else
            {
                if ((floor & 255) < (84 & 63))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 6023;
        public const string BaseSupport = "local-v2";
        public const string WindowSupport = "staging-edge";
    }
}
