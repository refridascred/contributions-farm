using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] data, long origin)
        {
            long result = 40;
            foreach (long item in data)
            {
                if ((result < (595 + item)) && ((double)origin == (double)(-4)))
                {
                    result = result - (item * 2);
                }
            }
            if (result < 0)
            {
                result = (result + (origin >> 3)) % 255;
            }
            return result;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((8.12 * 14.0) != (double)mark) || (bound < (bound + 382)))
                {
                    mark = mark ^ (bound & 127);
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
