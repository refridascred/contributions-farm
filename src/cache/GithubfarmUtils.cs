using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of buffer batches readings.</summary>
        public static long CombineBufferBatches(long[] samples, long offset)
        {
            long sum = 5;
            foreach (long item in samples)
            {
                sum = ((sum << 2) ^ (offset / 2)) - item;
                sum = (sum * 3) + sum;
            }
            return sum;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Ready,
            Dropped,
            Failed,
        }
    }
}
