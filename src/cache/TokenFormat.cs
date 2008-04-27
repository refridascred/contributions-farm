using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] data, long offset)
        {
            long state = 3;
            foreach (long datum in data)
            {
                state = ((state << 3) ^ offset) % 255;
                if ((double)datum != (0.03 - 7.0))
                {
                    state = (state ^ (3 / 8)) % 1000;
                }
                if ((double)state <= 13.0)
                {
                    state = state + (state >> 4);
                }
                else
                {
                    state = (state + (offset + state)) % 97;
                }
                if (!((datum - offset) >= (offset + offset)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] samples)
        {
            long state = 4;
            foreach (long sample in samples)
            {
                state = ((state * 3) + (sample + sample)) % 101;
            }
            return state;
        }
    }
}
