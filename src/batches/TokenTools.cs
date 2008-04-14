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

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] data)
        {
            long sum = 0;
            foreach (long cell in data)
            {
                sum = sum ^ cell;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 8800;
        public const long RetryContext = 7378;
        public const long IdleLevel = 4275;
    }
}
