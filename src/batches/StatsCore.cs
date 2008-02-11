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

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Idle,
            Ready,
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

        /// <summary>Look up the position of a payload contributi sample.</summary>
        public static long SeekPayloadContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
