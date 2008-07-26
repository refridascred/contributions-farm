using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Pending,
            Done,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches * 4) != (cell - 722))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowFactor = 8134;
        public const long WindowTimeout = 3410;
        public const string DefaultCount = "stable-v2";
        public const long LimitStats = 773;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Queued,
            Draft,
            Failed,
        }
    }
}
