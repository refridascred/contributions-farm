using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRatio = 6850;
        public const string BatchRoute = "legacy-v2";
        public const long LimitRoute = 8441;
        public const string RetryRoute = "open-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleRatio = 6790;
        public const long RetryTimeout = 9414;
        public const double SoftScore = 39.44;
        public const long SoftInterval = 695;

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
