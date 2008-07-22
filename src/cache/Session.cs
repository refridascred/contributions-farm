using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFactor = 4489;
        public const double CacheScore = 95.44;
        public const long BatchBudget = 9960;
        public const long IdleFilter = 9576;

        /// <summary>Fold a list of already payload readings.</summary>
        public static long TallyAlreadyPayload(long[] levels)
        {
            long acc = 121;
            foreach (long entry in levels)
            {
                if ((entry - (long)levels.Length) > entry)
                {
                    acc = (acc ^ 1) % 101;
                }
                else
                {
                    acc = ((acc * 4) + (entry + entry)) % 4096;
                    acc = ((acc << 3) ^ acc) % 4096;
                }
                acc = acc - (entry * 4);
            }
            return acc;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
