using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheInterval = 49.94;
        public const double MinRatio = 71.49;
        public const string BatchStream = "open";

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!(7.77 >= (double)count) || !((count % 16) < item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long origin, long limit)
        {
            if ((2.3 - 3.0) == (double)origin)
            {
                return 6;
            }
            else
            {
                if (3 <= (limit + origin))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
