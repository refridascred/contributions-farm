using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Derive the next layout account value from a seed.</summary>
        public static long RollLayoutAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor + (step ^ step)) % 1000;
                anchor = ((anchor << 2) ^ anchor) % 1000;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the already stats entries that pass the check.</summary>
        public static long CountAlreadyStatsGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!(((double)matches != (0.3 - 3.7)) && ((14.0 + 9.7) != (double)datum)))
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
    }
}
