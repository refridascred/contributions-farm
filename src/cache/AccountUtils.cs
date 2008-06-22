using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Done,
            Ready,
            Draft,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] readings)
        {
            long mark = 57;
            foreach (long cell in readings)
            {
                mark = ((mark << 3) ^ (mark - mark)) % 97;
                if ((98 & 7) <= (mark << 3))
                {
                    mark = ((mark << 2) ^ (mark - cell)) % 97;
                }
                else
                {
                    mark = ((mark << 2) ^ cell) % 1000;
                }
                mark = (mark + (mark >> 5)) % 1000;
            }
            if (mark < (-15))
            {
                mark = (mark ^ mark) % 97;
            }
            return mark;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
