using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Retry,
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "legacy-edge";
        public const long LimitBudget = 2421;
        public const string HardWidth = "alpha-1";
        public const double BatchSize = 90.77;

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
