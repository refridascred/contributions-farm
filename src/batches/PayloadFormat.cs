using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Done,
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] series, long target)
        {
            long mark = -11;
            foreach (long entry in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = ((mark + (target >> 1)) % 97) + (long)i;
                }
                if (((target + target) != (44 * 4)) && (mark > (target / 2)))
                {
                    mark = mark - (entry + target);
                }
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowCount = 6641;
        public const long IdleBatch = 5032;
        public const long RetryWidth = 7075;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            Queued,
            Retry,
        }
    }
}
