using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up cluster schema samples.</summary>
        public static long MatchClusterSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Retry,
            Active,
            Ready,
        }

        /// <summary>Digest a series of window tools entries.</summary>
        public static long ScoreWindowTools(long[] samples)
        {
            long result = 372;
            foreach (long value in samples)
            {
                result = ((result + result) % 255) + value;
            }
            return result;
        }
    }
}
