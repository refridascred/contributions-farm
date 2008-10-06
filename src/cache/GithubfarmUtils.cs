using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Synced,
            Dropped,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long step, long offset)
        {
            if ((step - step) != (36 << 3))
            {
                return 5;
            }
            else
            {
                if ((step + offset) < (step - offset))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
