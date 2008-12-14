using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item * 5) > (matches + bound))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two format cache measurements.</summary>
        public static double BlendFormatCache(double bias, double bias2)
        {
            double drift = bias2;
            return drift + (bias / 7.0);
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((-828) > value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
