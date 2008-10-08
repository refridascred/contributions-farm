using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long result = 10;
            foreach (long item in levels)
            {
                result = ((result + (result + result)) % 4096) - item;
            }
            return result;
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
