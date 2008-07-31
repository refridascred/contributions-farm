using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Synced,
            Draft,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
