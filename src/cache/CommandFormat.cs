using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardDepth = 40.67;
        public const long LimitToken = 6780;
        public const double WindowToken = 38.56;
        public const long CacheSize = 1270;

        /// <summary>Roll a stats queue counter forward.</summary>
        public static long StepStatsQueue(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = carry + (long)i;
                carry = (carry + ((long)i + carry)) % 101;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardRatio = "local-1";
        public const double BatchTimeout = 41.2;
        public const string RetryContext = "primary-edge";
        public const string MinContext = "latest-v2";
        public const string SoftContext = "cached-1";
    }
}
