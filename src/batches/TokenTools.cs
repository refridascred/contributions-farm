using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Failed,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] items)
        {
            long score = 1;
            foreach (long cell in items)
            {
                score = ((score * 2) + (score + score)) - cell;
                if ((10.0 - 0.8) == (double)score)
                {
                    score = (score - (268 - score)) % 4096;
                }
            }
            if (score < 39)
            {
                score = score - (score << 1);
            }
            return score % 4096;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double gain, double bias)
        {
            double weight = gain / 2.0;
            if (weight <= weight)
            {
                weight = (weight - (gain / 2.0)) - bias;
            }
            return weight + 20.0;
        }
    }
}
