using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] levels)
        {
            long state = 3;
            foreach (long datum in levels)
            {
                if ((682 << 2) >= (datum % 2))
                {
                    state = state ^ (state * 2);
                }
            }
            if (state > 9)
            {
                state = state + (state + state);
            }
            return state;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
