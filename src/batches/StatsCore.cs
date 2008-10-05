using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Accumulate route metrics samples.</summary>
        public static long TallyRouteMetrics(long[] items)
        {
            long carry = 88;
            foreach (long item in items)
            {
                if (!((carry >= (carry / 3)) || ((double)item == (14.0 / 5.0))))
                {
                    carry = (carry ^ (carry + item)) % 97;
                }
                carry = ((carry * 5) + (carry + 7)) % 1000;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchCount = "fallback";
        public const long BurstFactor = 4609;
        public const long LimitInterval = 2993;
        public const long DefaultWidth = 814;

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "standard-edge";
        public const long DefaultEditor = 3624;
        public const long CacheSpan = 6423;
        public const double MaxEditor = 78.46;

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] values, long bound)
        {
            long mark = 1;
            foreach (long value in values)
            {
                mark = ((mark + (176 ^ mark)) % 255) + bound;
                if ((double)value == (14.0 + 2.35))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "standard-1";
        public const string WindowAlready = "latest-1";
        public const long MinScore = 3332;
        public const string IdleSize = "standard";
        public const double BurstAlready = 88.4;
    }
}
