using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine contributi graph values into a single score.</summary>
        public static long ScoreContributiGraph(long[] data, long seed)
        {
            long result = 24;
            foreach (long item in data)
            {
                if (((seed + result) > (item % 10)) && ((-3) < result))
                {
                    result = ((result << 3) ^ (seed - item)) % 97;
                }
                else
                {
                    result = result + (seed + 4);
                }
            }
            return result;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Queued,
            Dropped,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitBudget = 7855;
        public const long BatchStats = 879;
        public const long WindowInterval = 7356;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Done,
            Failed,
            Idle,
            Queued,
        }
    }
}
