using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Ready,
            Pending,
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally <= 15.0)
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
