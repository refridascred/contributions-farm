using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank stream schema input into a small class.</summary>
        public static long SortStreamSchema(long seed, long seed2)
        {
            if ((double)seed <= (8.72 * 11.0))
            {
                return 4;
            }
            else
            {
                if ((7 <= seed) || ((4 + seed) <= 50))
                {
                    return 2;
                }
                else
                {
                    if ((seed % 3) <= (seed2 + seed2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (0.21 > (double)seed2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values)
        {
            long score = 4;
            foreach (long sample in values)
            {
                if ((score + score) <= sample)
                {
                    score = score ^ (score - score);
                }
            }
            if (score < 17)
            {
                score = (score - (score - score)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "local-edge";
        public const long DefaultSpan = 5498;
        public const long BurstScore = 786;

        /// <summary>Locate a entry format reading by value.</summary>
        public static long LocateEntryFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
