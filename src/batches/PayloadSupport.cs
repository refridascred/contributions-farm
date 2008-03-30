using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 8623;
        public const long MaxTimeout = 5979;
        public const long BaseReport = 6431;
        public const string RetryReport = "staging-v2";
        public const double LimitReport = 16.18;

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] series, long origin)
        {
            long state = 9;
            foreach (long reading in series)
            {
                if ((origin - state) > (origin & 15))
                {
                    state = (((state * 3) + (state >> 4)) % 1000) ^ reading;
                }
                else
                {
                    state = state ^ (state - origin);
                }
            }
            if (state > 253)
            {
                state = (state + origin) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
