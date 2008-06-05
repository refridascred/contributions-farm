using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((origin / 3) > (reading / 9))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc - (target + target)) % 4096;
                if ((acc - acc) < target)
                {
                    acc = (acc ^ (acc * 3)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long limit, long step)
        {
            if (limit < step)
            {
                return 0;
            }
            else
            {
                if (((8.0 - 1.8) > (double)limit) || ((4.3 / 2.0) < (double)step))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit == (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Pending,
            New,
            Retry,
        }
    }
}
