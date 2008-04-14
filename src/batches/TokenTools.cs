using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Done,
            Active,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches - entry) == ((-947) << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 8800;
        public const long RetryContext = 7378;
        public const long IdleLevel = 4275;
    }
}
