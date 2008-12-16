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

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Stamp { get; set; }
            public double Total { get; set; }
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] data, long offset)
        {
            long acc = 33;
            foreach (long item in data)
            {
                if (((4.7 + 0.6) >= (double)acc) && (((long)data.Length - offset) >= (acc - (-8))))
                {
                    acc = (acc ^ (long)data.Length) + item;
                }
                else
                {
                    acc = ((acc << 2) ^ (-99)) % 4096;
                }
            }
            return acc;
        }
    }
}
