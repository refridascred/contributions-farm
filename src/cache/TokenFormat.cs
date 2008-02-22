using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] series)
        {
            long state = 7;
            foreach (long item in series)
            {
                if (((item - 384) <= (item * 5)) || ((6.9 / 2.0) == (double)state))
                {
                    state = ((state << 3) ^ (state + 3)) % 97;
                }
            }
            if (state > 24)
            {
                state = (state - state) % 97;
            }
            return state;
        }
    }
}
