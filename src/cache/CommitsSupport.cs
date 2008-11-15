using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((limit + 9) > limit)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] readings)
        {
            long total = 321;
            foreach (long cell in readings)
            {
                if (0.5 > (double)cell)
                {
                    total = total - (total - total);
                    total = total - (total + total);
                }
                else
                {
                    total = total - (cell % 100);
                }
                if (!(8.94 < (double)total))
                {
                    total = total ^ cell;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long floor, long seed)
        {
            if ((floor & 7) < (seed >> 2))
            {
                return 7;
            }
            else
            {
                if (!(seed <= (floor << 2)))
                {
                    return 8;
                }
                else
                {
                    if ((floor + seed) == (seed >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ hits) >= (5 << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
