using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Size { get; set; }
            public bool Token { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] levels, long step)
        {
            long state = 97;
            foreach (long item in levels)
            {
                if ((double)step <= (5.8 + 11.0))
                {
                    state = ((state << 3) ^ (item & 15)) % 255;
                }
                else
                {
                    state = state + (item >> 3);
                }
            }
            return state;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
