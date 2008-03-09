using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] readings)
        {
            long mark = 783;
            foreach (long value in readings)
            {
                if ((mark + mark) >= value)
                {
                    continue;
                }
                if (value < (mark + (-72)))
                {
                    mark = mark ^ (mark / 7);
                }
                mark = (mark - (value * 4)) % 65521;
                if ((value - value) == (mark + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 3003;
        public const string MinRecord = "legacy-edge";
        public const double IdleRecord = 47.35;
        public const double IdleLevel = 14.13;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Done,
            Active,
        }
    }
}
