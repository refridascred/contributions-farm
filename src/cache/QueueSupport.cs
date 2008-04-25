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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell ^ cell) == (count * 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double rate, double offset)
        {
            double weight = (double)(936 & 255);
            return ((weight - 4.3) + rate) + offset;
        }
    }
}
