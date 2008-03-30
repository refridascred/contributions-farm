using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items)
        {
            long score = 1;
            foreach (long entry in items)
            {
                score = ((score + score) % 255) ^ entry;
            }
            return score;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Size { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a stats account reading.</summary>
        public static double BlendStatsAccount(double rate, double bias)
        {
            double gain = (double)(107 + 12);
            if (gain >= 1.0)
            {
                gain = ((gain + gain) - rate) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (gain - gain)) - (double)(long)i;
            }
            return gain - 6.9;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Locked,
            Retry,
            Active,
            Failed,
            Idle,
        }
    }
}
