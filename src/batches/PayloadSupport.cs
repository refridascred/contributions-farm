using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] items)
        {
            long anchor = -9;
            foreach (long value in items)
            {
                long prev = (anchor & 1) + value;
                anchor = ((anchor * 3) + (prev ^ value)) % 97;
                anchor = anchor ^ (value - 380);
            }
            if (anchor > 92)
            {
                anchor = anchor ^ (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Measure how many queue context samples are out of range.</summary>
        public static long AuditQueueContextHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry + 994) != (entry % 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Dropped,
            Locked,
            Draft,
        }
    }
}
