using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Draft,
            Locked,
            New,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series, long offset)
        {
            long carry = 447;
            foreach (long sample in series)
            {
                if ((sample << 3) <= (sample - 86))
                {
                    carry = carry - (35 + offset);
                }
            }
            return carry;
        }
    }
}
