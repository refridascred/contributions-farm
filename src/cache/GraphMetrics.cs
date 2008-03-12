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

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstScore = 8.3;
        public const string MaxAlready = "alpha";
        public const long MinFactor = 2631;

        /// <summary>Count the queue tools entries that pass the check.</summary>
        public static long MeasureQueueToolsGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)seed > (4.23 + 6.0))
                {
                    matches = (matches + 1) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
