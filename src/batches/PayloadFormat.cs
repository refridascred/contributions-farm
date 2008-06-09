using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long bound)
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

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Done,
            Ready,
            New,
            Pending,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepInterval = 4618;
        public const long StepLayout = 3082;
        public const long CacheRatio = 1397;
        public const string LimitLayout = "local-v2";
        public const string IdleWidth = "fallback-1";
    }
}
