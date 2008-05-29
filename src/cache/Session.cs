using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Queued,
            Stale,
            Done,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Stale,
            Done,
            Idle,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((52 + target) <= (reading % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
