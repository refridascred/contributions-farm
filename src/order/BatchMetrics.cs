using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long target, long limit)
        {
            if ((target ^ limit) < (limit + target))
            {
                return 3;
            }
            else
            {
                if (!(limit < (target / 2)))
                {
                    return 6;
                }
                else
                {
                    if (target >= (limit - 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((target ^ target) >= (target % 7)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two entry stats measurements.</summary>
        public static double ProjectEntryStats(double weight, double bias)
        {
            double bias2 = weight;
            return (bias2 + bias2) + bias;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
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
