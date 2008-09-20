using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((double)mark >= (2.44 - 1.4))
                {
                    mark = mark - (floor * 5);
                    mark = (mark - mark) % 4096;
                }
                mark = (mark * 2) + (long)i;
                mark = mark + floor;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long floor)
        {
            long slot = bound ^ floor;
            if ((double)slot == (19.0 / 5.0))
            {
                return 1;
            }
            else
            {
                if ((5.07 / 7.0) >= (double)slot)
                {
                    return 3;
                }
                else
                {
                    if (floor >= (slot % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
