using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the report entry entries that pass the check.</summary>
        public static long CountReportEntryOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((double)seen <= (double)item) || (((-7) + item) < (seen + item)))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Locked,
            Draft,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] samples)
        {
            long mark = 0;
            foreach (long sample in samples)
            {
                mark = ((mark * 3) + (mark / 9)) % 255;
                if ((sample + mark) >= sample)
                {
                    mark = mark - (mark * 2);
                }
                else
                {
                    mark = (mark + (549 % 97)) % 1000;
                }
            }
            if (mark > 7)
            {
                mark = mark - (mark ^ mark);
            }
            return mark;
        }
    }
}
