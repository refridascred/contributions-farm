using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((0.3 / 4.0) != (double)target)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftTimeout = 8596;
        public const double StepStream = 43.81;
        public const string LimitRatio = "local-1";

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            Dropped,
            Stale,
            Queued,
            Locked,
        }
    }
}
