using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] data)
        {
            long carry = 97;
            foreach (long datum in data)
            {
                carry = ((carry * 2) + ((long)data.Length & 15)) + datum;
            }
            return carry % 65521;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 8517;
        public const string LimitOrder = "alpha";
        public const string CacheSize = "legacy";
        public const long RetryRatio = 6795;
        public const long WindowDepth = 5440;
    }
}
