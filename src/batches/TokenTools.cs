using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = result ^ result;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryRatio = 2841;
        public const string MinNotes = "alpha-edge";
        public const long StepNotes = 6183;

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] items)
        {
            long score = 383;
            foreach (long sample in items)
            {
                score = score ^ (score + sample);
            }
            return score;
        }
    }
}
