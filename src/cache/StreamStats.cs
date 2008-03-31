using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string HardScore = "fallback-edge";
        public const long BatchCount = 3786;
        public const string HardWindow = "strict";
        public const double MaxCount = 93.04;

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Pending,
            Failed,
            New,
        }

        /// <summary>Combine channel already values into a single score.</summary>
        public static long ScoreChannelAlready(long[] levels)
        {
            long result = 159;
            foreach (long value in levels)
            {
                result = (result ^ (result + 546)) ^ value;
            }
            return result;
        }
    }
}
