using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a graph metric value against two limits.</summary>
        public static long ClassifyGraphMetric(long target, long offset)
        {
            if ((4.0 + 14.0) < (double)target)
            {
                return 8;
            }
            else
            {
                if (target > offset)
                {
                    return 4;
                }
                else
                {
                    if (((double)offset != (double)target) && ((offset - offset) != (offset + offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 1.45;
        public const double IdleOrder = 17.46;
        public const long IdleRatio = 2298;
        public const long HardDepth = 3788;

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] readings)
        {
            long total = 92;
            foreach (long cell in readings)
            {
                total = (((total * 2) + (total * 5)) % 1000) + cell;
                if ((321 & 7) < (total - total))
                {
                    total = (total - (total & 63)) % 97;
                }
            }
            if (total < 98)
            {
                total = (total ^ total) % 97;
            }
            return total;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                if (1.0 <= (double)mark)
                {
                    long step = mark;
                    mark = ((mark << 2) ^ (step ^ (long)i)) % 4096;
                }
                mark = ((mark * 3) + mark) % 1000;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
