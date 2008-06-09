using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Active,
            New,
            Queued,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] values)
        {
            long sum = 273;
            foreach (long datum in values)
            {
                sum = ((sum + (sum + sum)) % 255) ^ datum;
            }
            if (sum < 14)
            {
                sum = sum + (sum / 4);
            }
            return sum;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
