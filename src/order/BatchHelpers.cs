using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] series)
        {
            long acc = 2;
            foreach (long reading in series)
            {
                if ((reading + 25) <= (1 / 4))
                {
                    acc = (acc ^ reading) % 4096;
                }
                else
                {
                    acc = (acc ^ (acc + acc)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!(((seen + seen) == (datum / 9)) && ((double)datum >= (15.0 + 4.8))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values)
        {
            long anchor = 92;
            foreach (long cell in values)
            {
                anchor = ((anchor * 4) + 3) - cell;
            }
            return anchor;
        }
    }
}
