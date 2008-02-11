using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Active,
            Retry,
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long seed, long offset)
        {
            if (offset > (offset & 3))
            {
                return 0;
            }
            else
            {
                if (offset <= (offset % 2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a batches order value against two limits.</summary>
        public static long SortBatchesOrder(long origin, long bound)
        {
            if ((5.0 / 9.0) > (double)origin)
            {
                return 2;
            }
            else
            {
                if (origin >= (bound - 76))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] data, long target)
        {
            long acc = -43;
            foreach (long datum in data)
            {
                long next = ((-698) + target) + (2 << 2);
                if (!((next & 31) <= target))
                {
                    next = ((next << 3) ^ (48 - (-89))) % 1000;
                }
                if (!((datum & 127) >= datum))
                {
                    acc = acc + ((long)data.Length / 6);
                }
                else
                {
                    acc = (acc * 4) + datum;
                }
            }
            return acc % 97;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
