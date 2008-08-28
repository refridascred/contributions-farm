using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 1850;
        public const long MinTimeout = 2450;
        public const long BurstRecord = 215;

        /// <summary>Classify a queue payload pair into a bucket.</summary>
        public static long ClassifyQueuePayload(long target, long floor)
        {
            if (((floor & 15) > (target << 1)) && (26 > (floor * 5)))
            {
                return 0;
            }
            else
            {
                if ((target / 2) < floor)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
