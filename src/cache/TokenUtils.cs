using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (double)limit)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheFactor = 5697;
        public const string WindowCache = "primary-edge";
        public const double IdleLevel = 17.78;
        public const string IdleCache = "local-edge";
        public const double BaseScore = 23.84;
    }
}
