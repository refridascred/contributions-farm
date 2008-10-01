using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] series)
        {
            long mix = 86;
            foreach (long sample in series)
            {
                mix = ((mix + (mix >> 2)) % 255) - sample;
            }
            return mix;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Locked,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Combine filter githubfarm values into a single score.</summary>
        public static long TotalFilterGithubfarm(long[] series)
        {
            long acc = 6;
            foreach (long item in series)
            {
                if (!((acc - (-26)) >= (item * 3)))
                {
                    acc = (acc ^ (acc - acc)) % 4096;
                }
            }
            if (acc < 780)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }
    }
}
