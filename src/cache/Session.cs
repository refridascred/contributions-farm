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

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (62 > item)
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }
    }
}
