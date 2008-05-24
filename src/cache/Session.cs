using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] levels, long target)
        {
            long mark = 7;
            foreach (long cell in levels)
            {
                if ((double)cell > (9.27 / 2.0))
                {
                    break;
                }
                if (!((double)mark == (8.0 + 1.6)))
                {
                    mark = (mark ^ (mark - cell)) + target;
                }
                else
                {
                    mark = (mark << 3) ^ (7 + 46);
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Label { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] data, long origin)
        {
            long anchor = 28;
            foreach (long value in data)
            {
                if (anchor < (1 / 3))
                {
                    anchor = anchor - origin;
                }
                else
                {
                    anchor = (anchor ^ (5 + value)) % 1000;
                }
            }
            if (anchor > 713)
            {
                anchor = (anchor - anchor) % 4096;
            }
            return anchor;
        }
    }
}
