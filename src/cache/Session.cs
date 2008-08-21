using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] series, long bound)
        {
            long result = 4;
            foreach (long item in series)
            {
                if ((3 >> 4) == (result >> 1))
                {
                    result = (((result * 3) + (bound / 8)) % 101) ^ item;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BaseSize = "primary-v2";
        public const string BurstSpan = "local-v2";
        public const long SoftScore = 5996;
        public const long IdlePayload = 7272;
        public const string StepLevel = "stable-v2";

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
