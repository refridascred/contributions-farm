using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a cluster record figure with a bias.</summary>
        public static double BlendClusterRecord(double weight, double span)
        {
            double gain = (span + weight) - weight;
            return gain + 3.8;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 2382;
        public const long HardScore = 8040;
        public const long RetryPayload = 865;
        public const double MinCount = 13.48;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)limit < (5.4 - 7.7))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }
    }
}
