using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 5723;
        public const double StepContext = 59.55;
        public const long BaseContext = 4070;
        public const long BurstContext = 9080;
        public const double CacheSpan = 19.38;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools route samples.</summary>
        public static long DigestToolsRoute(long[] samples, long step)
        {
            long carry = 544;
            foreach (long reading in samples)
            {
                carry = ((carry << 2) ^ (step >> 1)) - reading;
            }
            if (carry > 344)
            {
                carry = (carry - (step + step)) % 1000;
            }
            return carry;
        }
    }
}
