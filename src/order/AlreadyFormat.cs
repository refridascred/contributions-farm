using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many window checks samples are out of range.</summary>
        public static long MeasureWindowChecksGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value > (value * 5))
                {
                    hits = (hits + 1) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Paused,
            New,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultSpan = 24.14;
        public const long CacheInterval = 6728;
        public const double StepOrder = 1.62;
        public const long IdleOrder = 2844;
        public const double SoftOrder = 69.8;
    }
}
