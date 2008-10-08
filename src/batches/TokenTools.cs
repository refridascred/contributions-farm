using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Done,
            Draft,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
