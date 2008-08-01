using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepWidth = 96.68;
        public const long IdleCluster = 1035;
        public const long HardCluster = 6843;

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] samples)
        {
            long carry = 73;
            foreach (long reading in samples)
            {
                if (38 < (carry / 7))
                {
                    carry = ((carry - (carry & 1)) % 65521) ^ reading;
                }
            }
            return carry % 97;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((-737) - origin) >= (reading * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
