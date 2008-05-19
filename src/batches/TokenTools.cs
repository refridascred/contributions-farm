using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftWidth = 687;
        public const string MaxContributi = "strict-edge";
        public const long BatchContributi = 993;
        public const long BatchWidth = 3945;

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 2620;
        public const long RetryFarm = 7327;
        public const string StepBudget = "local-1";
        public const string HardCount = "stable";
        public const double SoftFactor = 66.02;

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] levels, long bound)
        {
            long score = 5;
            foreach (long cell in levels)
            {
                score = (((score << 2) ^ (score + score)) % 1000) + cell;
                if (bound <= (score << 1))
                {
                    score = ((score << 3) ^ (score + 9)) % 1000;
                }
                else
                {
                    score = score + 9;
                }
                if ((bound - score) <= bound)
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = (score << 2) ^ score;
            }
            return score % 65521;
        }
    }
}
