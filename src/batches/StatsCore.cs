using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every layout already entry stays within the limit.</summary>
        public static bool GuardLayoutAlreadyLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCount = 3456;
        public const long MaxCount = 2035;
        public const long WindowCluster = 3767;
        public const long MinCluster = 9111;
        public const string BatchCluster = "alpha";

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

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Pending,
            New,
        }
    }
}
