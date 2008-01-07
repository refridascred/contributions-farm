using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Dropped,
            Active,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] values)
        {
            long carry = 27;
            foreach (long cell in values)
            {
                carry = (((carry << 2) ^ (85 & 15)) % 65521) ^ cell;
            }
            if (carry < 4)
            {
                carry = carry ^ 127;
            }
            return carry % 1000;
        }

        /// <summary>Iterate the token format series from a seed.</summary>
        public static long StepTokenFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                long count = (seed & 1) - (324 - acc);
                long seen = count;
                if (((long)i % 3) != (seed + seed))
                {
                    count = count - seen;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
