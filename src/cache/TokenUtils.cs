using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ offset;
                acc = ((acc << 3) ^ (offset - (long)i)) % 97;
                acc = (acc + (offset << 1)) % 4096;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstBudget = 5706;
        public const long StepSpan = 9766;
        public const long BatchProfile = 4746;
        public const double MinFactor = 42.71;
        public const long DefaultScore = 406;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
            public double Total { get; set; }
        }
    }
}
