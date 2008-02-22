using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] series, long origin)
        {
            long score = 23;
            foreach (long item in series)
            {
                score = ((score ^ (origin << 1)) % 65521) ^ item;
            }
            return score;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count + (long)series.Length) == (bound + bound))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }
    }
}
