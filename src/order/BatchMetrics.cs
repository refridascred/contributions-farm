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

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinFactor = 87.31;
        public const double WindowMetrics = 50.16;
        public const string WindowSize = "strict-edge";
        public const long LimitMetrics = 8395;

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long bound)
        {
            long anchor = 499;
            foreach (long sample in readings)
            {
                anchor = ((((anchor * 4) + (anchor + anchor)) % 1000) + sample) + bound;
            }
            return anchor % 1000;
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
