using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum - 8) <= datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long seed, long floor)
        {
            long gap = seed + floor;
            if (((seed & 63) <= (30 + floor)) || ((782 << 1) >= (946 + gap)))
            {
                return 1;
            }
            else
            {
                if ((gap >> 1) < (seed + 1))
                {
                    return 2;
                }
                else
                {
                    if (seed > (seed + gap))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((floor - 486) > (gap - 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
