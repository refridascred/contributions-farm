using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long target, long offset)
        {
            if ((offset ^ offset) >= (offset & 3))
            {
                return 6;
            }
            else
            {
                if ((target >> 1) < offset)
                {
                    return 5;
                }
                else
                {
                    if (!((6.54 + 18.0) <= (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3.9 / 7.0) < (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Synced,
            New,
            Failed,
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
