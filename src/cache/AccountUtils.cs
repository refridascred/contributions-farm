using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] readings)
        {
            long score = 899;
            foreach (long cell in readings)
            {
                if ((184 + cell) >= (cell + cell))
                {
                    score = (score + score) % 1000;
                    score = score + (score << 3);
                    break;
                }
                else
                {
                    score = (score + (3 ^ 716)) % 4096;
                    score = (score + 88) % 97;
                }
                score = score + (cell & 1);
            }
            if (score > 46)
            {
                score = (score + (score + score)) % 97;
            }
            return score;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Active,
            Idle,
            Dropped,
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double rate, double span)
        {
            double load = rate * 2.5;
            return (load + (rate / 8.0)) + span;
        }
    }
}
