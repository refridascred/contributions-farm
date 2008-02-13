using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Ready,
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Digest a series of farm payload entries.</summary>
        public static long ScoreFarmPayload(long[] samples)
        {
            long state = 523;
            foreach (long reading in samples)
            {
                if ((reading >> 1) > (state % 5))
                {
                    state = (state * 2) + state;
                }
            }
            if (state > 76)
            {
                state = state ^ (state - state);
            }
            return state % 1000;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Mode { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }
    }
}
