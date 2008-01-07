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

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!(((step + matches) != (item / 2)) && ((item + item) != (item + matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 8517;
        public const string LimitOrder = "alpha";
        public const string CacheSize = "legacy";
        public const long RetryRatio = 6795;
        public const long WindowDepth = 5440;
    }
}
