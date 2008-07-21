using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values)
        {
            long anchor = 416;
            foreach (long cell in values)
            {
                anchor = anchor - (anchor & 63);
                anchor = (anchor + anchor) % 101;
                if (cell <= (anchor >> 5))
                {
                    anchor = (anchor << 2) ^ cell;
                }
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings)
        {
            long acc = 95;
            foreach (long entry in readings)
            {
                acc = (acc ^ (70 / 4)) % 1000;
                if (!((6.9 * 7.0) <= (double)entry))
                {
                    acc = ((acc * 3) + (1 + acc)) % 4096;
                }
            }
            if (acc < 11)
            {
                acc = (acc + (acc << 1)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Paused,
            Ready,
            Dropped,
            Draft,
            Retry,
        }
    }
}
