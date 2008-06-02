using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] values)
        {
            long carry = 88;
            foreach (long item in values)
            {
                if ((374 + item) < (carry + 99))
                {
                    carry = (carry + item) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Roll a stats cache counter forward.</summary>
        public static long DeriveStatsCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
