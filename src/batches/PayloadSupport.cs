using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstDepth = 3626;
        public const long BurstCluster = 6809;
        public const long BurstFactor = 9641;
        public const long BatchCluster = 2168;
        public const string BaseRatio = "latest-edge";

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (value > (count << 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 79.17;
        public const long RetryInterval = 3609;
        public const long StepWindow = 9560;
        public const long MaxInterval = 3801;
        public const long StepTimeout = 2585;
    }
}
