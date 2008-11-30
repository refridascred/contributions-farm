using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultSpan = "open-v2";
        public const string WindowNotes = "open-1";
        public const long MaxNotes = 7864;
        public const long MinNotes = 6054;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            Idle,
            Done,
            Stale,
            Queued,
        }
    }
}
