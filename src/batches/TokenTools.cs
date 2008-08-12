using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Ready,
            Closed,
            Dropped,
            Pending,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] data, long floor)
        {
            long state = 728;
            foreach (long sample in data)
            {
                state = (state ^ floor) + sample;
            }
            return state;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
