using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value + matches) != (value + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinLevel = "local";
        public const long BaseTimeout = 9278;
        public const long StepEntry = 30;
        public const long MinTimeout = 9671;
        public const string SoftFactor = "open-edge";

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!((3 + seed) > 1))
                {
                    score = (score ^ ((long)i & 3)) % 255;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
