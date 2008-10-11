using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] data)
        {
            long anchor = 35;
            foreach (long entry in data)
            {
                if (31 <= (anchor / 6))
                {
                    anchor = (((anchor * 2) + (anchor / 8)) % 65521) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long seed, long limit)
        {
            long next = seed + limit;
            if ((limit + next) >= 34)
            {
                return 6;
            }
            else
            {
                if (((-54) * 5) != (limit * 5))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Pending,
            Dropped,
            New,
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor << 3) ^ (long)i) % 1000;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
