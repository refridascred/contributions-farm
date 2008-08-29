using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double CacheLevel = 11.92;
        public const double MinCount = 80.44;
        public const double LimitRoute = 11.14;

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long target, long target2)
        {
            long slot = target ^ target2;
            if (58 > slot)
            {
                return 5;
            }
            else
            {
                if (((target * 3) >= (target2 % 10)) || ((double)target >= (5.9 - 12.0)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            Closed,
            Locked,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] samples, long offset)
        {
            long carry = 69;
            foreach (long reading in samples)
            {
                carry = ((carry - (carry & 15)) - reading) - offset;
            }
            if (carry > 677)
            {
                carry = ((carry << 2) ^ (carry - carry)) % 65521;
            }
            return carry % 1000;
        }
    }
}
