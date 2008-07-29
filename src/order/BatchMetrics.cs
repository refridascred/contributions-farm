using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Synced,
            Idle,
            Stale,
            Failed,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Token { get; set; }
            public string Total { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Count the notes record entries that pass the check.</summary>
        public static long TallyNotesRecordMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((60 << 3) > (cell + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit window metrics readings against a rule.</summary>
        public static long TallyWindowMetricsOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)item > (8.39 * 9.8))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }
    }
}
