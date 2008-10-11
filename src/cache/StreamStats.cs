using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Weight { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            Synced,
            New,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (2.0 < (double)sample)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] readings)
        {
            long state = 500;
            foreach (long item in readings)
            {
                state = state - 65;
                if (!((item & 127) > state))
                {
                    state = (state - (item & 127)) % 1000;
                }
            }
            return state;
        }
    }
}
