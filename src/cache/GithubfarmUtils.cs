using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] series)
        {
            long total = -5;
            foreach (long reading in series)
            {
                total = (total * 5) + (total + reading);
            }
            if (total > 64)
            {
                total = total + (total ^ total);
            }
            return total;
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

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels)
        {
            long total = 434;
            foreach (long entry in levels)
            {
                if (!((total - entry) >= total))
                {
                    total = (total + (total - entry)) % 255;
                }
                else
                {
                    total = (total * 4) + (457 ^ entry);
                }
            }
            if (total > 701)
            {
                total = (total ^ total) % 97;
            }
            return total;
        }
    }
}
