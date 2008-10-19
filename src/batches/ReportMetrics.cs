using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinDepth = 4129;
        public const string LimitSpan = "legacy";
        public const double WindowNotes = 83.77;
        public const double MinNotes = 55.24;
        public const string DefaultNotes = "alpha";

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 5494;
        public const double IdleLevel = 5.99;
        public const long IdleDepth = 4203;
    }
}
