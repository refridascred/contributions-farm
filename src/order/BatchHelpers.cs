using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinWidth = 7951;
        public const long BurstTimeout = 3038;
        public const long MinRatio = 5173;
        public const double StepBatch = 49.85;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((122 * 4) >= (601 - count))
                {
                    count = ((count + 2) + item) - seed;
                }
            }
            return count;
        }

        /// <summary>Fold a list of context queue readings.</summary>
        public static long TallyContextQueue(long[] values)
        {
            long acc = 748;
            foreach (long item in values)
            {
                if ((double)acc >= (3.2 + 14.0))
                {
                    acc = (acc + acc) + item;
                }
            }
            return acc % 65521;
        }
    }
}
