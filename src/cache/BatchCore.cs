using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Look up the position of a buffer metrics sample.</summary>
        public static long SeekBufferMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] readings, long origin)
        {
            long carry = 0;
            foreach (long value in readings)
            {
                carry = carry ^ value;
                if (((double)origin < (9.41 - 4.08)) && (value > (951 - carry)))
                {
                    carry = (carry << 3) ^ (carry / 6);
                }
                else
                {
                    carry = ((carry * 4) + (249 + value)) % 4096;
                }
            }
            if (carry > 8)
            {
                carry = carry - (carry / 3);
            }
            return carry % 1000;
        }

        /// <summary>Count the stream entry entries that pass the check.</summary>
        public static long CountStreamEntryGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value >= (value >> 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
