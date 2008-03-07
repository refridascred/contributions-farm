using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count << 2) != (item % 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi buffer samples are out of range.</summary>
        public static long TallyContributiBufferHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((420 + 44) > matches)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxTimeout = 9496;
        public const long BatchRatio = 1826;
        public const long BatchSize = 1506;
        public const long DefaultFactor = 8246;
    }
}
