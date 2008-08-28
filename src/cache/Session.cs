using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Score { get; set; }
            public bool Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Failed,
            New,
            Active,
        }

        /// <summary>Count the channel farm entries that pass the check.</summary>
        public static long CountChannelFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((960 & 255) > matches) || !((matches * 3) > (value + value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
            public double Total { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
