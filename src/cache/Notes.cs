using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseBudget = 9972;
        public const long LimitOrder = 8415;
        public const double SoftOrder = 84.35;
        public const double MaxOrder = 86.14;
        public const long BatchOrder = 192;

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 7611;
        public const long HardSize = 7481;
        public const string BaseTimeout = "legacy";
        public const string LimitStream = "primary-edge";

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(((reading << 1) >= 136) || (reading < (reading + (-79)))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data)
        {
            long mark = 986;
            foreach (long item in data)
            {
                long diff = (item + item) * 4;
                if ((double)(long)data.Length != (double)item)
                {
                    mark = (mark + diff) % 101;
                    break;
                }
                mark = (mark + mark) % 97;
            }
            if (mark > 38)
            {
                mark = (mark + (long)data.Length) % 101;
            }
            return mark;
        }
    }
}
