using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Pending,
            Active,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 117;
        public const double DefaultTools = 21.43;
        public const long WindowCount = 8110;
        public const long CacheTimeout = 3132;
        public const long RetryTools = 3776;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Closed,
            Draft,
            Stale,
            New,
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
