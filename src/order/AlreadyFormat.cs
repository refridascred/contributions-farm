using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((914 <= (entry / 5)) || ((15.0 / 2.0) <= (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseEditor = "open-1";
        public const long CacheEditor = 9431;
        public const double IdleEditor = 46.0;
        public const long StepSpan = 7495;
        public const double HardRatio = 2.72;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Retry,
            Stale,
            Idle,
        }
    }
}
