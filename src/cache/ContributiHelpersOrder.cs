using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Locked,
            Active,
            Ready,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 3935;
        public const double MaxTools = 75.01;
        public const string HardSpan = "open";
        public const long MinTools = 9347;
        public const long RetryTools = 635;

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((2.8 - 10.0) > (double)limit)
                {
                    score = (score - (long)i) % 65521;
                    score = (score + (limit - score)) % 101;
                }
                score = (score - (score >> 2)) % 255;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
