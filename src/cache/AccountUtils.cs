using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a buffer notes reading.</summary>
        public static double ProjectBufferNotes(double ratio, double offset)
        {
            double ratio2 = (double)(42 - 33);
            if (ratio2 > (ratio2 * 13.0))
            {
                ratio2 = (ratio2 - (ratio - 3.0)) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen / 9) >= datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
