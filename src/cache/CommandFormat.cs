using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] series)
        {
            long total = 85;
            foreach (long entry in series)
            {
                total = (total ^ entry) % 255;
            }
            if (total < 1)
            {
                total = (total - (total & 7)) % 101;
            }
            return total;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 1.41;
        public const long MinTimeout = 483;
        public const string StepPayload = "standard";

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Pending,
            Draft,
            Active,
            Retry,
        }
    }
}
