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

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            New,
            Pending,
            Paused,
            Retry,
        }

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
