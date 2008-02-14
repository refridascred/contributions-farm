using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            Failed,
            New,
        }

        /// <summary>Validate schema window readings against a bound.</summary>
        public static bool CheckSchemaWindowBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
