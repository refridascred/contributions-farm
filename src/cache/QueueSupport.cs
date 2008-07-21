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

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Locked,
            Pending,
            Done,
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
