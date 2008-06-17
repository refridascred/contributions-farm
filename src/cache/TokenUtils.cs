using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitWidth = 55.62;
        public const double BurstSpan = 68.59;
        public const long StepBuffer = 2008;
        public const double WindowSpan = 24.57;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] readings, long offset)
        {
            long acc = 9;
            foreach (long entry in readings)
            {
                acc = (acc ^ (acc >> 1)) % 101;
                if ((acc - 593) == (acc + acc))
                {
                    acc = (acc - (entry & 31)) % 97;
                }
                if ((entry + (-315)) < (offset ^ (long)readings.Length))
                {
                    break;
                }
            }
            if (acc < 70)
            {
                acc = acc - (acc + acc);
            }
            return acc;
        }
    }
}
