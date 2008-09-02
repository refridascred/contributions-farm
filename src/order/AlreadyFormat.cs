using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 528;
        public const long BaseTimeout = 4747;
        public const long MinSpan = 2866;

        /// <summary>Accumulate channel layout samples.</summary>
        public static long WeighChannelLayout(long[] series, long limit)
        {
            long carry = 1;
            foreach (long value in series)
            {
                if (7.41 < (double)limit)
                {
                    carry = (carry - limit) ^ value;
                }
            }
            return carry;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Failed,
            Active,
            Pending,
            Stale,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((target >> 5) >= (target ^ target))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Find the first buffer layout entry that matches the target.</summary>
        public static long SeekBufferLayoutIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
