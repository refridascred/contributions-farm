using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSpan = 22.19;
        public const string RetrySession = "standard-edge";
        public const long BurstSession = 4348;
        public const string CacheSize = "stable-edge";
        public const string LimitSession = "alpha-1";

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Compare every pair of metrics order readings.</summary>
        public static long MatchMetricsOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Ready,
            Queued,
        }
    }
}
