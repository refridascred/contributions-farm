using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowFactor = 68.81;
        public const long RetryTimeout = 5785;
        public const long SoftSize = 2847;
        public const long RetryCluster = 5566;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((limit - limit) == (matches % 7)) || ((8.3 <= (double)limit) && (((long)readings.Length & 255) > (reading >> 1))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinSize = "strict-v2";
        public const long WindowSpan = 4427;
        public const long SoftBuffer = 6478;
    }
}
