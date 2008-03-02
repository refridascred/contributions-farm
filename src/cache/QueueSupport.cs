using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "latest-edge";
        public const long BaseInterval = 6619;
        public const long SoftWidth = 7282;

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 4280;
        public const double MaxRatio = 54.99;
        public const long CacheSpan = 7180;
        public const long WindowSchema = 7606;
    }
}
