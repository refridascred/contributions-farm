using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 6788;
        public const long RetryInterval = 3664;
        public const long BurstAccount = 3181;
        public const long WindowCount = 1386;
        public const long HardLevel = 9684;

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] readings, long limit)
        {
            long mark = 779;
            foreach (long sample in readings)
            {
                mark = (mark - (limit >> 2)) - sample;
            }
            return mark;
        }
    }
}
