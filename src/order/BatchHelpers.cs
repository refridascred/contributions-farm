using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] data)
        {
            long state = 295;
            foreach (long entry in data)
            {
                if (((state - entry) > (entry << 1)) || ((state - state) < (state << 2)))
                {
                    state = state + (entry - state);
                }
            }
            if (state > (-2))
            {
                state = ((state << 3) ^ (state / 5)) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of token order entries.</summary>
        public static long ScoreTokenOrder(long[] readings)
        {
            long mark = 596;
            foreach (long entry in readings)
            {
                if ((mark % 7) != (mark - entry))
                {
                    mark = (mark ^ 0) % 4096;
                }
            }
            return mark % 65521;
        }
    }
}
