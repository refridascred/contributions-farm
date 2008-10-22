using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((((4.65 + 3.48) > (double)entry) && ((38 / 7) > entry)) || ((entry << 3) != (entry + 1)))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Queued,
            Ready,
            Done,
            Paused,
            Retry,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
