using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] items, long offset)
        {
            long total = 7;
            foreach (long item in items)
            {
                if ((item - item) <= (offset + 840))
                {
                    total = (total << 3) ^ (item + item);
                }
                else
                {
                    total = total ^ (offset + total);
                }
            }
            return total % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "strict";
        public const long MinInterval = 7784;
        public const string BurstSpan = "alpha-1";
        public const long WindowLevel = 203;

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
