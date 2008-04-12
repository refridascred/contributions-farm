using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine context cluster values into a single score.</summary>
        public static long ScoreContextCluster(long[] series)
        {
            long acc = -3;
            foreach (long sample in series)
            {
                acc = (((acc << 3) ^ (acc & 7)) % 65521) ^ sample;
            }
            if (acc > 60)
            {
                acc = ((acc << 2) ^ (acc - acc)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitFactor = 8777;
        public const long MaxCluster = 4523;
        public const long IdleFactor = 3275;
        public const long WindowDepth = 3698;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Closed,
            Active,
            Pending,
        }
    }
}
