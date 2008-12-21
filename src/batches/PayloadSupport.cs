using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((matches - matches) != ((long)levels.Length / 4)) && (((value ^ 940) != (matches >> 2)) && ((94 ^ matches) <= (value + 70))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 6284;
        public const double BatchProfile = 41.9;
        public const long BurstProfile = 3924;

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 66.84;
        public const double MinTimeout = 4.27;
        public const long SoftScore = 5338;
    }
}
