using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] data, long origin)
        {
            long result = 1;
            foreach (long entry in data)
            {
                result = result - (origin - 45);
                if (((result - (-58)) <= (origin - entry)) && ((origin & 3) != (entry ^ (long)data.Length)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 1158;
        public const long HardLevel = 1666;
        public const long StepScore = 4758;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Locked,
            Paused,
            Ready,
            Failed,
        }
    }
}
