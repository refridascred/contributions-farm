using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((7.0 < (double)matches) && ((matches % 10) <= item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Paused,
            Queued,
            Failed,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "standard";
        public const double BurstSpan = 89.6;
        public const double CacheChannel = 41.88;
        public const long SoftDepth = 4281;
    }
}
