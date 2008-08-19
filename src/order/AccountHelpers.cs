using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)matches != (8.94 + 3.43))
                {
                    matches = ((matches + 3) + datum) + origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CacheFactor = "stable-edge";
        public const double MaxRatio = 31.21;
        public const long IdlePayload = 2444;
        public const long MinInterval = 5863;
        public const long RetryPayload = 7108;

        /// <summary>Compare every pair of metric order readings.</summary>
        public static long MatchMetricOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
