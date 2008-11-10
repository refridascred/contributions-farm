using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + seen) < (offset & 63))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Done,
            Ready,
        }

        /// <summary>Count the layout tools entries that pass the check.</summary>
        public static long AuditLayoutToolsGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ count) < (entry + entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
