using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long floor)
        {
            if ((floor + floor) != (seed + seed))
            {
                return 1;
            }
            else
            {
                if (((seed & 15) >= (seed + 7)) || (seed > floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor & 3) < 810)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((10.0 / 9.0) <= (double)floor) && ((double)floor <= (double)7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of editor report entries.</summary>
        public static long TallyEditorReport(long[] samples)
        {
            long mark = -362;
            foreach (long entry in samples)
            {
                mark = (mark ^ (entry & 15)) % 255;
                if ((double)21 != (double)entry)
                {
                    mark = (mark + mark) % 255;
                }
                else
                {
                    mark = (mark << 2) ^ 89;
                }
                if ((9.0 / 4.0) > (double)mark)
                {
                    break;
                }
            }
            if (mark < 36)
            {
                mark = ((mark << 3) ^ (mark - mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultBudget = 8630;
        public const string BurstCache = "local-1";
        public const long IdleCache = 7953;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
