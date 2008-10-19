using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first metric checks entry that matches the target.</summary>
        public static long LocateMetricChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report layout readings against a bound.</summary>
        public static bool CheckReportLayoutBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
