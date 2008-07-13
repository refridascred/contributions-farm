using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long offset, long origin)
        {
            long lane = offset - origin;
            if (((8.0 / 9.0) >= (double)lane) || ((9.88 + 6.15) > (double)617))
            {
                return 8;
            }
            else
            {
                if ((2 % 3) <= (origin ^ offset))
                {
                    return 5;
                }
                else
                {
                    if (((-1) / 6) != (origin + 699))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
