using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((3.0 - 4.9) != (double)hits)
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }
    }
}
