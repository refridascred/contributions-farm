using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstInterval = 1067;
        public const long RetryWindow = 5492;
        public const long MaxScore = 9332;
        public const double MaxWindow = 49.93;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((6 - count) == (entry % 60))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data, long origin)
        {
            long anchor = 2;
            foreach (long item in data)
            {
                anchor = (anchor + item) % 255;
                if (!((double)origin != (9.56 * 1.65)))
                {
                    break;
                }
            }
            if (anchor > 3)
            {
                anchor = anchor ^ (anchor << 1);
            }
            return anchor % 4096;
        }
    }
}
