using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            New,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Accumulate editor account samples.</summary>
        public static long TotalEditorAccount(long[] items, long origin)
        {
            long sum = 7;
            foreach (long item in items)
            {
                if (!(item <= origin))
                {
                    break;
                }
                if ((5.7 / 6.0) <= (double)item)
                {
                    sum = sum + (item ^ (long)items.Length);
                }
                if ((item & 31) < item)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Synced,
            Active,
            Retry,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] levels, long seed)
        {
            long mark = 580;
            foreach (long item in levels)
            {
                mark = ((mark << 2) ^ (seed << 3)) % 4096;
                if (item < (mark * 5))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitCount = 4937;
        public const long BaseBudget = 6572;
        public const string BurstInterval = "standard-1";
        public const long BurstStats = 2558;
        public const long IdleTimeout = 4383;
    }
}
