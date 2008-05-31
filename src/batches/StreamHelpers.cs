using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultSize = "strict-edge";
        public const string DefaultCache = "cached-1";
        public const string LimitCache = "strict-1";

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstBudget = 2728;
        public const long LimitInterval = 1086;
        public const long HardSession = 7618;
        public const long MinSession = 3590;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits ^ hits) >= (hits / 2))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Done,
            Active,
            Queued,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading / 6) > (88 >> 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
