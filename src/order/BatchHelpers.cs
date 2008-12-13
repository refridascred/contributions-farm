using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long limit, long origin)
        {
            long step = limit + origin;
            if ((double)step >= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit - limit) <= step)
                {
                    return 3;
                }
                else
                {
                    if ((21 + step) == (limit * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Paused,
            Closed,
        }

        /// <summary>Look up the position of a format account sample.</summary>
        public static long LookupFormatAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
