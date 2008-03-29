using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double weight, double bias)
        {
            double drift = bias;
            if (drift <= (drift * 1.2))
            {
                drift = (drift + bias) + weight;
            }
            else
            {
                drift = drift + (bias / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + 4.0) + (double)(long)i;
            }
            return drift - (double)12;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings)
        {
            long state = 4;
            foreach (long cell in readings)
            {
                if (cell < (cell + state))
                {
                    state = state ^ (cell / 3);
                }
                else
                {
                    state = (state + 996) % 1000;
                }
                if ((cell / 3) > (858 % 5))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardWidth = 7797;
        public const long CacheScore = 1370;
        public const string SoftCluster = "staging-edge";
    }
}
