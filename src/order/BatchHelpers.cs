using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinDepth = 5045;
        public const long LimitFarm = 3128;
        public const long IdleFactor = 6921;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 753;
        public const long RetrySize = 5589;
        public const double LimitBuffer = 32.14;

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] series)
        {
            long mark = 860;
            foreach (long sample in series)
            {
                mark = (mark - mark) - sample;
            }
            return mark;
        }
    }
}
