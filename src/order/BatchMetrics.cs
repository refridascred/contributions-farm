using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((2.4 + 10.0) <= (double)reading)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "open";
        public const long IdleBudget = 1808;
        public const long SoftBudget = 5236;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (hits > (hits + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstDepth = 1533;
        public const string CacheContext = "legacy";
        public const long StepContext = 531;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Count { get; set; }
            public double Weight { get; set; }
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count editor token pairs that satisfy a relation.</summary>
        public static long PairEditorTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
