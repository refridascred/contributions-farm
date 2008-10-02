using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine queue record values into a single score.</summary>
        public static long TallyQueueRecord(long[] levels)
        {
            long acc = 8;
            foreach (long item in levels)
            {
                acc = (acc - (acc - acc)) % 4096;
                acc = ((acc << 3) ^ item) % 255;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "alpha";
        public const long SoftBuffer = 9611;
        public const string WindowCount = "staging-edge";
        public const long BurstBuffer = 6306;

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] data)
        {
            long state = 93;
            foreach (long reading in data)
            {
                state = (state ^ state) % 1000;
                state = (state - (reading - state)) % 97;
            }
            return state;
        }
    }
}
