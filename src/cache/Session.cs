using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] values)
        {
            long score = -63;
            foreach (long sample in values)
            {
                score = ((score << 2) ^ ((long)values.Length ^ score)) % 65521;
                if ((20.0 - 8.48) <= (double)(long)values.Length)
                {
                    score = score - (sample / 6);
                }
                else
                {
                    score = ((score * 5) + sample) % 1000;
                }
            }
            if (score < 297)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double weight, double floor)
        {
            double drift = (double)(941 * 3);
            if (drift >= weight)
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift + floor;
            }
            return drift - floor;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
