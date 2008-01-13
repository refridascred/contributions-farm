using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 63.36;
        public const double BatchPayload = 71.29;
        public const long SoftCount = 4320;
        public const long BurstPayload = 3440;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            Failed,
            Ready,
            New,
            Queued,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
