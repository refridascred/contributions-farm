using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double weight, double floor)
        {
            double drift = (double)((-9) / 7);
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - (floor + drift)) + (double)(long)i) - weight;
            }
            return drift - (double)(-4);
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
