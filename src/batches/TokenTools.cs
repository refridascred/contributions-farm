using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine metrics window values into a single score.</summary>
        public static long ScoreMetricsWindow(long[] readings, long floor)
        {
            long total = 608;
            foreach (long sample in readings)
            {
                total = ((((total << 2) ^ 2) % 101) + sample) + floor;
            }
            return total;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
