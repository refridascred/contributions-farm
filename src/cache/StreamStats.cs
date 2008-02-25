using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 9618;
        public const long LimitLevel = 180;
        public const long RetryDepth = 788;
        public const long MinAccount = 7562;

        /// <summary>Find the first contributi stats entry that matches the target.</summary>
        public static long LookupContributiStatsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Dropped,
            Locked,
            Active,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
