using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Failed,
            Idle,
            New,
        }

        /// <summary>Locate a payload record reading by value.</summary>
        public static long SeekPayloadRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell < (1.3 + 2.74))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }
    }
}
