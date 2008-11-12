using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Done,
            Active,
            Idle,
            Queued,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 625;
        public const double BurstSize = 95.16;
        public const long StepSupport = 1587;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count + 75) >= 2)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((floor2 + 3) <= floor2)
            {
                return 5;
            }
            else
            {
                if (((-865) - 221) < (cur >> 2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
