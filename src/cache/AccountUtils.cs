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

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] levels, long limit)
        {
            long result = 8;
            foreach (long item in levels)
            {
                if ((result - limit) <= (-93))
                {
                    continue;
                }
                result = (result ^ item) % 65521;
                if ((0.95 * 2.0) < (double)item)
                {
                    result = result + (result / 7);
                }
                if (result <= (result + result))
                {
                    break;
                }
            }
            return result;
        }
    }
}
