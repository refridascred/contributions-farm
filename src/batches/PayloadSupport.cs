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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (18.0 >= (double)matches)
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }
    }
}
