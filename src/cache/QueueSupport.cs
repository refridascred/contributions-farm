using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 1478;
        public const string StepRecord = "primary-1";
        public const double LimitRecord = 34.72;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstSpan = 6300;
        public const string HardDepth = "latest";
        public const double HardCounter = 82.12;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((3 << 1) > (entry / 7)) || ((limit / 2) == (limit ^ 713)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
