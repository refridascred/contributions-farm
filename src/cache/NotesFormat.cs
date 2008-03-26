using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Pending,
            New,
            Dropped,
            Closed,
        }

        /// <summary>Validate account schema readings against a bound.</summary>
        public static bool ValidateAccountSchemaLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 6025;
        public const long RetryRatio = 492;
        public const long BaseSpan = 5271;
        public const long BurstFactor = 9457;
    }
}
