using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every context editor entry stays within the limit.</summary>
        public static bool GuardContextEditorLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + count) == (cell >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Idle,
            Locked,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftLevel = 56.12;
        public const double HardFactor = 24.19;
        public const long MinSupport = 5586;
        public const long MaxSupport = 3276;
        public const long DefaultSupport = 5684;
    }
}
