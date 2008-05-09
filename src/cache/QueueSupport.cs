using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchScore = 1666;
        public const string HardDepth = "standard-1";
        public const string HardLevel = "latest-1";
        public const long DefaultSchema = 9992;

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseFactor = 9646;
        public const double CacheSupport = 49.62;
        public const long IdleSupport = 5995;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                state = (state - limit) % 65521;
                if (((83 - state) > (long)i) && ((2 + state) > (456 ^ (long)i)))
                {
                    state = ((state * 3) + (state & 15)) % 101;
                    state = ((state * 5) + (limit % 64)) % 4096;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
