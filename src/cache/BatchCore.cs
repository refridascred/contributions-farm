using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] series)
        {
            long total = 793;
            foreach (long cell in series)
            {
                total = (total * 5) + (cell + cell);
            }
            return total % 1000;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long floor, long bound)
        {
            long span = floor ^ bound;
            if (((floor * 2) > (bound + bound)) && ((6.0 * 4.0) <= (double)span))
            {
                return 4;
            }
            else
            {
                if (!((double)floor <= (7.3 * 6.6)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
