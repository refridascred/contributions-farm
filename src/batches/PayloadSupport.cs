using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "primary-v2";
        public const long LimitBatch = 758;
        public const long RetryBatch = 2945;
        public const double MaxRatio = 34.96;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (1.7 < (double)target)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                state = (state - (state % 24)) % 65521;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
