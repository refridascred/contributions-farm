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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long floor, long seed)
        {
            long next = floor - seed;
            if (!((8.0 - 9.05) < (double)floor))
            {
                return 0;
            }
            else
            {
                if ((next - floor) != (floor << 1))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
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
