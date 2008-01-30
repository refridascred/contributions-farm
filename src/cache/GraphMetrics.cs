using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every format session entry stays within the limit.</summary>
        public static bool ValidateFormatSessionRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxInterval = 8429;
        public const long StepEditor = 2456;
        public const long LimitEditor = 9377;
        public const string HardDepth = "primary-v2";
        public const long WindowEditor = 4288;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long result = 9;
            foreach (long entry in data)
            {
                if ((result >= (result << 2)) && ((double)result >= (14.0 + 7.85)))
                {
                    result = result - (entry - entry);
                }
                if (result >= (entry >> 3))
                {
                    result = (result + (1 * 4)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheSpan = 78.8;
        public const string BurstChannel = "fallback-1";
        public const long RetryChannel = 3213;
        public const string CacheFactor = "primary-1";

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
