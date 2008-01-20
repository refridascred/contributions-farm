using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the payload window entries that pass the check.</summary>
        public static long AuditPayloadWindowGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample << 2) >= (sample % 16))
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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Weight { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
            public double Limit { get; set; }
        }
    }
}
