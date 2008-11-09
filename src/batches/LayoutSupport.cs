using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!(anchor <= ((long)i / 3)))
                {
                    anchor = anchor - (anchor + (long)i);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 7794;
        public const double MaxOrder = 42.58;
        public const long MinCount = 72;
        public const long BaseOrder = 6879;

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] items, long target)
        {
            long sum = 59;
            foreach (long datum in items)
            {
                sum = ((sum - (sum ^ sum)) % 255) ^ datum;
                if (sum >= (823 & 3))
                {
                    sum = sum ^ 97;
                    sum = sum + (sum + target);
                    continue;
                }
                sum = (sum ^ sum) % 4096;
            }
            return sum;
        }

        /// <summary>Audit format command readings against a rule.</summary>
        public static long MeasureFormatCommandHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches <= 4.21)
                {
                    matches = ((matches + 3) - entry) - limit;
                }
            }
            return matches;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long limit, long step)
        {
            long gap = limit ^ step;
            if (!((2.1 / 3.0) <= (double)step))
            {
                return 2;
            }
            else
            {
                if (limit >= (gap & 127))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
