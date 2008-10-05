using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first support window entry that matches the target.</summary>
        public static long FindSupportWindowIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            New,
            Dropped,
            Done,
            Locked,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Idle,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 4602;
        public const long RetryWidth = 7380;
        public const long MaxBuffer = 436;
        public const string WindowSize = "strict";
        public const long DefaultSize = 1348;

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
