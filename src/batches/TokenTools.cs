using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 6160;
        public const string MinToken = "fallback-edge";
        public const double BaseToken = 83.89;
        public const string MinWidth = "latest";
        public const string HardWidth = "legacy-1";

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            Stale,
            Closed,
            Done,
            Ready,
        }

        /// <summary>Locate a metrics farm reading by value.</summary>
        public static long LookupMetricsFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
