using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 18.52;
        public const long MinFormat = 3874;
        public const string LimitCount = "open";

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((9.4 * 0.19) > (double)tally)
                {
                    tally = ((tally + 3) ^ item) + bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            Closed,
            Dropped,
            New,
            Synced,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)count >= (1.03 - 0.6))
                {
                    count = ((count + 3) + reading) + floor;
                }
            }
            return count;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
