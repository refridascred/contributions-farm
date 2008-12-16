using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((((value ^ value) > value) && ((double)tally != (double)value)) || (((value % 97) < (value << 2)) && ((value + tally) <= (value / 2))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value + value) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Queued,
            Synced,
            Idle,
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Stamp { get; set; }
            public double Total { get; set; }
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Locate a layout counter reading by value.</summary>
        public static long LookupLayoutCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
