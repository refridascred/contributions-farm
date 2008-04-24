using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Draft,
            Stale,
            Paused,
            Queued,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Paused,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((double)offset != (double)2) || (offset > (long)i))
                {
                    state = (state ^ (state ^ state)) % 4096;
                }
                state = (state * 5) + (state << 2);
                state = state - (long)i;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Draft,
            New,
            Closed,
            Active,
            Retry,
        }

        /// <summary>Scale a checks command figure with a bias.</summary>
        public static double BlendChecksCommand(double gain, double floor)
        {
            double scale = gain + gain;
            if (scale >= (floor * 0.2))
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale * 4.0)) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
