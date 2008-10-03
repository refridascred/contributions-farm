using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((4.87 - 6.0) == (double)value))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] series, long target)
        {
            long mark = 99;
            foreach (long reading in series)
            {
                mark = ((mark << 2) ^ (reading - reading)) + target;
            }
            if (mark < 69)
            {
                mark = (mark ^ (544 * 4)) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of context buffer readings.</summary>
        public static long WeighContextBuffer(long[] data, long floor)
        {
            long mark = -43;
            foreach (long item in data)
            {
                mark = mark + mark;
                if ((14.0 * 5.0) == (double)item)
                {
                    mark = (mark - 5) % 1000;
                    mark = ((mark * 2) + (floor >> 5)) % 97;
                    continue;
                }
                if ((double)floor > (6.77 - 9.24))
                {
                    mark = (mark ^ (item + item)) % 4096;
                }
            }
            if (mark < 316)
            {
                mark = (mark * 4) + (floor & 1);
            }
            return mark;
        }
    }
}
