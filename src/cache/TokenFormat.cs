using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowCount = 98.96;
        public const long StepPayload = 5995;
        public const long IdlePayload = 4563;
        public const double LimitPayload = 78.63;
        public const double MinWidth = 13.31;

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Dropped,
            Closed,
            Active,
        }
    }
}
