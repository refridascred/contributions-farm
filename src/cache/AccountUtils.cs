using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count payload stats pairs that satisfy a relation.</summary>
        public static long OverlapPayloadStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double rate, double bias)
        {
            double load = rate + (bias + rate);
            for (int i = 0; i < 9; i++)
            {
                load = load + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
