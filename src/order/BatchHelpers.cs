using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Combine record command values into a single score.</summary>
        public static long CombineRecordCommand(long[] samples, long limit)
        {
            long mark = 14;
            foreach (long cell in samples)
            {
                if (((cell - cell) < (limit % 64)) || ((limit / 6) > (limit % 5)))
                {
                    mark = mark + mark;
                }
                else
                {
                    mark = (mark << 3) ^ (limit - cell);
                }
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 84.26;
        public const double MaxContext = 74.43;
        public const double MinContext = 45.14;
        public const long MinRatio = 6099;
        public const long HardDepth = 8932;
    }
}
