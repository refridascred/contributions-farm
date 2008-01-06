using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] levels, long origin)
        {
            long result = 43;
            foreach (long entry in levels)
            {
                if (((double)result >= (double)origin) || (origin >= (result + 9)))
                {
                    result = (result + (entry ^ origin)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardInterval = 6.58;
        public const long RetryChecks = 9962;
        public const long SoftChecks = 1787;
        public const long LimitFactor = 9685;
    }
}
