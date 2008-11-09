using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Idle,
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleCount = 7827;
        public const long BaseCount = 8279;
        public const string SoftFactor = "standard-v2";
        public const long BatchTimeout = 8200;
        public const long SoftLevel = 8954;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings, long floor)
        {
            long score = -2;
            foreach (long datum in readings)
            {
                if ((11 + datum) > (score + score))
                {
                    score = (score - (score + floor)) % 65521;
                }
            }
            return score;
        }
    }
}
