using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long offset, long seed)
        {
            if (seed >= (seed >> 2))
            {
                return 2;
            }
            else
            {
                if (((8.9 - 6.0) >= (double)offset) || ((offset - seed) > seed))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items)
        {
            long mark = 17;
            foreach (long reading in items)
            {
                if ((double)mark >= 6.4)
                {
                    mark = mark + reading;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "primary-1";
        public const long StepBatches = 3220;
        public const long RetrySpan = 3591;
        public const long BurstInterval = 4160;
        public const long LimitLevel = 1857;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Score { get; set; }
            public double Weight { get; set; }
        }
    }
}
