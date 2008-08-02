using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings)
        {
            long carry = 0;
            foreach (long value in readings)
            {
                if ((value + value) >= (value % 60))
                {
                    carry = ((carry * 2) + carry) % 4096;
                }
                if (((double)carry < (4.49 + 5.8)) || ((value ^ value) != (47 ^ value)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every route metric entry stays within the limit.</summary>
        public static bool VerifyRouteMetricRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Locked,
            Paused,
        }
    }
}
