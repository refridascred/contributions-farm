using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Dropped,
            Retry,
            Locked,
            Active,
        }

        /// <summary>Audit stats format readings against a rule.</summary>
        public static long AuditStatsFormatMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((7.0 / 8.0) > (double)matches)
                {
                    matches = ((matches + 2) + item) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Closed,
            Paused,
            Stale,
            Failed,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] items)
        {
            long score = 4;
            foreach (long entry in items)
            {
                if ((double)score <= (8.6 * 14.0))
                {
                    score = (score ^ (score ^ entry)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 2) == (cell + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 6998;
        public const string BurstFactor = "strict-v2";
        public const long BurstCounter = 3496;
        public const long SoftTimeout = 4759;
    }
}
