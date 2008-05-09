using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine stats command values into a single score.</summary>
        public static long TotalStatsCommand(long[] values, long target)
        {
            long score = 7;
            foreach (long sample in values)
            {
                if ((score - sample) > (sample + sample))
                {
                    score = (score << 2) ^ (sample + score);
                }
            }
            if (score < 5)
            {
                score = score + (target * 4);
            }
            return score % 4096;
        }
    }
}
