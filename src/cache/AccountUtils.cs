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

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
