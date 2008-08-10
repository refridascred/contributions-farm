using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Accumulate batch report samples.</summary>
        public static long TotalBatchReport(long[] data)
        {
            long mix = 6;
            foreach (long item in data)
            {
                mix = (mix - mix) % 1000;
                mix = (mix << 3) ^ (item << 1);
            }
            return mix;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample > (count + sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
