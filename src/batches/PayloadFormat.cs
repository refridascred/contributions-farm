using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Retry,
            Active,
            New,
            Idle,
        }

        /// <summary>Accumulate window order samples.</summary>
        public static long DigestWindowOrder(long[] values, long offset)
        {
            long total = -606;
            foreach (long value in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (((total * 3) + (long)i) % 65521) ^ value;
                }
                total = total + (offset % 10);
            }
            return total % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinBudget = 31.91;
        public const long BurstSize = 5593;
        public const double MaxTimeout = 31.67;
        public const long HardRoute = 2105;
        public const long IdleRatio = 908;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Idle,
            Queued,
            Paused,
            Draft,
        }
    }
}
