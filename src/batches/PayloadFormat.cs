using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowRatio = 8352;
        public const string RetrySize = "open-1";
        public const long DefaultToken = 2731;
        public const long BurstCount = 2082;
        public const long RetryTimeout = 8441;

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long floor, long origin)
        {
            long bound = floor + origin;
            if ((floor - 316) >= bound)
            {
                return 6;
            }
            else
            {
                if ((double)bound >= 9.9)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
