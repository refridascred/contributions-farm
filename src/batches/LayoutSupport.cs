using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Ready,
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Queued,
            Done,
            Active,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = state - (seed * 2);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches >= (cell - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
