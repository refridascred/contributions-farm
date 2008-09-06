using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((19 + item) == (target * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxRatio = 3838;
        public const string BaseFactor = "fallback-1";
        public const long BaseInterval = 5332;
        public const long HardBatch = 2618;
        public const long CacheRatio = 972;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Queued,
            Closed,
            Active,
            Done,
        }

        /// <summary>Audit record notes readings against a rule.</summary>
        public static long AuditRecordNotesHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (4.8 < (double)matches)
                {
                    matches = ((matches + 2) + entry) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
