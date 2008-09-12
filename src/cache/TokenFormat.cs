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

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitTimeout = 5807;
        public const string SoftNotes = "strict";
        public const double BurstSpan = 6.26;
        public const long WindowFactor = 4156;
    }
}
