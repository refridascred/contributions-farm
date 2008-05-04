using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!(state >= floor))
                {
                    state = state - (state - state);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen <= (seen - seen))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Closed,
            Failed,
            Draft,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)7 != (double)matches)
                {
                    matches = ((matches + 2) + sample) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
