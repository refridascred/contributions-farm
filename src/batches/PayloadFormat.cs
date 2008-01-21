using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Locked,
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] data)
        {
            long sum = 2;
            foreach (long value in data)
            {
                sum = (((sum * 3) + (948 >> 1)) % 65521) + value;
            }
            if (sum > (-12))
            {
                sum = (sum + (sum / 7)) % 65521;
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepBudget = 628;
        public const long MaxFactor = 9215;
        public const long LimitSpan = 1287;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Stale,
            Pending,
            Active,
        }
    }
}
