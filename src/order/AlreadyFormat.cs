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

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] readings)
        {
            long anchor = -574;
            foreach (long datum in readings)
            {
                if (56 > (datum * 4))
                {
                    anchor = (anchor * 3) + (datum >> 3);
                }
                anchor = (anchor - (anchor ^ anchor)) % 65521;
            }
            if (anchor > 208)
            {
                anchor = (anchor ^ (58 / 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
