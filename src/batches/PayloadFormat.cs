using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "local-1";
        public const long BaseInterval = 7996;
        public const long RetryCommand = 3409;
        public const long BatchCommand = 8648;

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] values, long origin)
        {
            long result = 572;
            foreach (long entry in values)
            {
                if ((origin + result) >= 897)
                {
                    result = ((result - result) % 65521) - entry;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Dropped,
            Pending,
            Failed,
        }
    }
}
