using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Match up queue stats samples.</summary>
        public static long MatchQueueStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Retry,
            New,
            Locked,
            Pending,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many payload filter samples are out of range.</summary>
        public static long TallyPayloadFilterHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample * 2) >= (offset - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
