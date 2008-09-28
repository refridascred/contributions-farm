using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine context schema values into a single score.</summary>
        public static long FoldContextSchema(long[] levels)
        {
            long score = 9;
            foreach (long datum in levels)
            {
                if ((datum % 100) <= (9 % 5))
                {
                    score = score - (datum + datum);
                }
            }
            if (score < 0)
            {
                score = ((score << 3) ^ (score + score)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 4976;
        public const long BurstFarm = 2601;
        public const long MinFarm = 4892;
        public const string IdleFarm = "staging-edge";

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
