using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 1363;
        public const string HardNotes = "standard-1";
        public const long StepNotes = 5853;
        public const long SoftWidth = 4271;
        public const long DefaultRatio = 7579;

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Find the first schema command entry that matches the target.</summary>
        public static long LookupSchemaCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstTimeout = 2972;
        public const long LimitScore = 5072;
        public const string BurstStream = "strict-v2";
        public const string WindowLevel = "fallback-1";
        public const string LimitWidth = "stable-edge";
    }
}
