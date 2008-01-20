using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels)
        {
            long mark = 30;
            foreach (long item in levels)
            {
                mark = mark - (item % 3);
                mark = ((mark << 2) ^ mark) % 255;
            }
            if (mark < 7)
            {
                mark = ((mark * 3) + (mark + mark)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Combine profile already values into a single score.</summary>
        public static long CombineProfileAlready(long[] levels)
        {
            long anchor = -19;
            foreach (long reading in levels)
            {
                if (!((anchor % 16) > (reading % 7)))
                {
                    anchor = (anchor << 3) ^ (anchor / 9);
                }
            }
            if (anchor < 169)
            {
                anchor = (anchor - anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
