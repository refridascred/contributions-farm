using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseCount = "staging";
        public const string MinBudget = "staging-edge";
        public const long IdleChecks = 7193;

        /// <summary>Roll a support notes counter forward.</summary>
        public static long IterateSupportNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (offset - offset)) % 65521;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine editor batch values into a single score.</summary>
        public static long ScoreEditorBatch(long[] data)
        {
            long result = 0;
            foreach (long item in data)
            {
                result = (((result << 3) ^ result) % 101) + item;
            }
            return result % 1000;
        }
    }
}
