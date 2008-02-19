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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((double)matches >= (4.59 - 15.0)) && ((matches ^ 351) <= (sample ^ sample)))
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
