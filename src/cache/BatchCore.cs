using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFactor = 86.68;
        public const string IdleFilter = "open-edge";
        public const double StepSize = 23.73;
        public const long WindowDepth = 3860;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Active,
            Done,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample - count) < sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
