using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Synced,
            Idle,
        }

        /// <summary>Iterate the report entry series from a seed.</summary>
        public static long RollReportEntry(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                if (((floor >> 1) < (floor ^ floor)) || ((double)floor < 5.76))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
