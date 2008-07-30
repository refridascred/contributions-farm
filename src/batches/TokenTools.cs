using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 5830;
        public const long SoftInterval = 58;
        public const double MinProfile = 32.24;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Failed,
            New,
        }
    }
}
