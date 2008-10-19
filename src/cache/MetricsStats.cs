using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryWidth = 2616;
        public const string MinEntry = "local-1";
        public const double BatchSpan = 39.4;
        public const double WindowEntry = 87.85;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowFactor = 9734;
        public const long CacheOrder = 1802;
        public const long BatchOrder = 4790;

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] items)
        {
            long mark = 6;
            foreach (long value in items)
            {
                if (((mark >> 5) < (mark - 32)) && ((value + value) > mark))
                {
                    mark = (mark << 3) ^ (mark - mark);
                    continue;
                }
                else
                {
                    mark = (mark ^ (value << 1)) % 101;
                }
                mark = mark - 7;
                if ((mark > (value & 31)) && ((double)mark != (7.0 / 7.0)))
                {
                    mark = mark ^ (mark % 16);
                }
                else
                {
                    mark = (mark - 39) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long target, long target2)
        {
            if (((target2 ^ target2) == (target % 7)) || ((0 & 63) == (target2 - target)))
            {
                return 0;
            }
            else
            {
                if ((target2 / 3) <= (target2 + (-6)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
