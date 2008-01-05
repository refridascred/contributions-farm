using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Idle,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate support stream samples.</summary>
        public static long DigestSupportStream(long[] readings)
        {
            long acc = 9;
            foreach (long value in readings)
            {
                acc = acc ^ 179;
                acc = ((acc << 3) ^ (acc << 3)) % 1000;
                if (((value >> 3) <= (acc >> 5)) && ((double)acc > (4.0 - 4.0)))
                {
                    acc = (acc ^ (value - acc)) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
