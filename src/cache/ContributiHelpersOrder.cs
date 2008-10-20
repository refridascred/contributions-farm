using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 7473;
        public const long BurstWidth = 4224;
        public const string StepInterval = "latest";

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor ^ (2 << 3);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Token { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
