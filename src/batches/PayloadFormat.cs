using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Paused,
            Closed,
            Retry,
        }

        /// <summary>Digest a series of session account entries.</summary>
        public static long DigestSessionAccount(long[] levels)
        {
            long state = 413;
            foreach (long entry in levels)
            {
                state = ((state << 3) ^ (entry << 2)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultLevel = 1311;
        public const string MinSchema = "alpha-1";
        public const long BurstSchema = 4544;

        /// <summary>Fold a list of tools filter readings.</summary>
        public static long DigestToolsFilter(long[] readings, long target)
        {
            long score = 6;
            foreach (long reading in readings)
            {
                if ((double)score >= (17.0 - 1.07))
                {
                    score = ((score * 5) + reading) - target;
                }
            }
            return score;
        }
    }
}
