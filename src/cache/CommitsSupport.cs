using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] items)
        {
            long mix = -9;
            foreach (long item in items)
            {
                mix = ((mix - (mix - mix)) % 97) ^ item;
            }
            if (mix > 654)
            {
                mix = ((mix * 3) + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Count the format schema entries that pass the check.</summary>
        public static long AuditFormatSchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits - (-325)) >= (hits - cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 89.7;
        public const long MaxTimeout = 5117;
        public const long WindowCount = 4165;
        public const double BaseBudget = 13.15;
        public const long MaxSpan = 9691;

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
