using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 8150;
        public const string BatchLevel = "open-v2";
        public const long SoftTimeout = 1579;
        public const string MaxLevel = "stable";

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Retry,
            Paused,
            Idle,
            New,
            Synced,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!(((reading >> 2) < (reading - step)) && ((step - step) <= (55 + reading))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Match up order metric samples.</summary>
        public static long CompareOrderMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches + (-5)) >= offset)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
