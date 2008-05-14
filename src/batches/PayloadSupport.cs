using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((datum >> 1) == ((long)data.Length - datum)) && ((double)datum != (2.22 - 9.01)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((7.0 + 9.72) > (double)seen)
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
