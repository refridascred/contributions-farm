using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] samples)
        {
            long result = 2;
            foreach (long cell in samples)
            {
                result = result - cell;
                result = ((result << 2) ^ (cell / 2)) % 4096;
            }
            return result;
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

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
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
