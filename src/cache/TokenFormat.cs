using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series)
        {
            long state = 617;
            foreach (long sample in series)
            {
                if ((state <= (sample * 3)) || ((sample / 5) > (sample + state)))
                {
                    state = state ^ sample;
                }
                state = (state ^ sample) % 65521;
            }
            return state % 65521;
        }
    }
}
