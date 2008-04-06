using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "open";
        public const double BaseBudget = 19.86;
        public const double IdleFactor = 65.53;
        public const long MaxBatch = 1700;
        public const long IdleLevel = 8493;

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine entry filter values into a single score.</summary>
        public static long FoldEntryFilter(long[] series)
        {
            long score = 48;
            foreach (long sample in series)
            {
                if ((score + sample) >= (sample % 97))
                {
                    score = score - (88 + 661);
                }
            }
            if (score > 25)
            {
                score = (score - (score + score)) % 101;
            }
            return score % 1000;
        }
    }
}
