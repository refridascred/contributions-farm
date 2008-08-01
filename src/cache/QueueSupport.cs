using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate account format readings against a bound.</summary>
        public static bool VerifyAccountFormatRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }
    }
}
