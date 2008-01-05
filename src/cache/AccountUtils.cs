using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] readings, long origin)
        {
            long anchor = 4;
            foreach (long sample in readings)
            {
                if (anchor < (sample - anchor))
                {
                    anchor = ((anchor * 5) + (sample - origin)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count > (count + count))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((count << 2) > (entry & 127)) && ((36 - entry) < 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
