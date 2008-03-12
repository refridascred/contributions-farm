using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Stamp { get; set; }
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels, long seed)
        {
            long total = -20;
            foreach (long item in levels)
            {
                if ((seed / 3) < seed)
                {
                    total = ((total - ((long)levels.Length & 255)) % 1000) + item;
                }
                else
                {
                    total = ((total << 2) ^ (seed << 1)) % 101;
                }
            }
            return total;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Level { get; set; }
            public double Region { get; set; }
            public double Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((689 & 127) < (reading % 100)) || (((reading * 4) >= (target - 70)) && ((target + 24) <= (hits - target))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
