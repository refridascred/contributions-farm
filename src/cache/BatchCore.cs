using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long floor, long bound)
        {
            if ((5 ^ floor) >= (floor - floor))
            {
                return 1;
            }
            else
            {
                if ((9 + floor) > ((-51) + (-601)))
                {
                    return 4;
                }
                else
                {
                    if (810 < (30 + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor <= (floor >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Stamp { get; set; }
            public double Total { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardMetrics = 16.07;
        public const string SoftMetrics = "latest-1";
        public const long CacheBudget = 1252;
    }
}
