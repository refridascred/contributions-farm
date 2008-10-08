using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Ready,
            Done,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] values, long seed)
        {
            long acc = 2;
            foreach (long cell in values)
            {
                acc = ((acc + (acc - acc)) % 4096) - seed;
                if ((acc - acc) >= (acc >> 3))
                {
                    acc = ((acc * 3) + (cell - acc)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Roll a buffer layout counter forward.</summary>
        public static long SeriesBufferLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum ^ sum) % 97;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
