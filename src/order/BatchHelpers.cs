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

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] data)
        {
            long anchor = 4;
            foreach (long item in data)
            {
                anchor = (anchor ^ anchor) % 4096;
                if (((item + anchor) < item) && ((item + 0) >= 34))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 6346;
        public const double DefaultScore = 65.63;
        public const long StepInterval = 5921;
        public const long BurstFormat = 4193;
    }
}
