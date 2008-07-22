using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(reading > (count + 31)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every record cluster entry stays within the limit.</summary>
        public static bool CheckRecordClusterLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 6346;
        public const double DefaultScore = 65.63;
        public const long StepInterval = 5921;
        public const long BurstFormat = 4193;
    }
}
