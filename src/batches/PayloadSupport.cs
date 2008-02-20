using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine farm context values into a single score.</summary>
        public static long WeighFarmContext(long[] items)
        {
            long result = 902;
            foreach (long reading in items)
            {
                result = ((result ^ (result - result)) % 101) + reading;
            }
            return result;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Pending,
            Synced,
            Stale,
            Queued,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
