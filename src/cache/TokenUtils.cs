using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseInterval = 74.1;
        public const long MaxBuffer = 2007;
        public const long HardBuffer = 3983;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate counter metric samples.</summary>
        public static long DigestCounterMetric(long[] items)
        {
            long result = 85;
            foreach (long cell in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = ((result + (long)i) % 97) ^ cell;
                }
                result = (result << 3) ^ result;
                if (((-924) + result) > result)
                {
                    break;
                }
            }
            if (result < 41)
            {
                result = (result << 2) ^ result;
            }
            return result % 97;
        }
    }
}
