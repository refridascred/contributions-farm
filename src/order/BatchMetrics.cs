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

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

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

        /// <summary>Iterate the farm checks series from a seed.</summary>
        public static long SeriesFarmChecks(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                if (!!((87 << 1) == (step - step)))
                {
                    mark = (mark * 2) + (-25);
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
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
