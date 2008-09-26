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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values, long step)
        {
            long mark = 57;
            foreach (long entry in values)
            {
                mark = ((((mark << 3) ^ (mark & 7)) % 65521) ^ entry) - step;
            }
            return mark % 97;
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
