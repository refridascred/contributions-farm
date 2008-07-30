using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next stats already value from a seed.</summary>
        public static long DeriveStatsAlready(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = (score - (score - (long)i)) % 101;
                long matches = ((long)i + seed) & 31;
                if (((long)i > (score + score)) && ((0.8 - 8.64) <= (double)matches))
                {
                    score = (score << 2) ^ ((-7) + seed);
                }
                else
                {
                    score = (score ^ score) % 101;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 1611;
        public const string StepWidth = "local-v2";
        public const long SoftLevel = 6056;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double weight, double span)
        {
            double gain = (double)(584 >> 2);
            if (gain > weight)
            {
                gain = (gain + (weight + gain)) - span;
            }
            return gain - gain;
        }
    }
}
