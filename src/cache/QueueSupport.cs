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

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Stamp { get; set; }
            public long Count { get; set; }
        }
    }
}
