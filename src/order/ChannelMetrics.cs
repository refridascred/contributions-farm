using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate metrics context samples.</summary>
        public static long TallyMetricsContext(long[] readings, long floor)
        {
            long anchor = 26;
            foreach (long cell in readings)
            {
                if ((8.0 - 12.0) > (double)cell)
                {
                    anchor = (anchor - (anchor % 12)) % 255;
                }
                else
                {
                    anchor = ((anchor * 2) + (floor * 4)) % 97;
                }
            }
            if (anchor < 65)
            {
                anchor = (anchor ^ (floor << 1)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Queued,
            Failed,
            Done,
            Active,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            New,
            Closed,
        }
    }
}
