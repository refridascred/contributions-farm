using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double RetryTimeout = 54.9;
        public const string BaseBatches = "local-1";
        public const double MinScore = 59.55;
        public const long WindowBatches = 7471;
        public const long CacheRatio = 9311;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry ^ (203 * 3)) % 255;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
