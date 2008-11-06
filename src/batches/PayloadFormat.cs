using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long target, long floor)
        {
            long next = target - floor;
            if (((5.48 / 6.0) > (double)next) && ((next >> 4) <= floor))
            {
                return 0;
            }
            else
            {
                if ((target & 31) >= (floor - next))
                {
                    return 6;
                }
                else
                {
                    if ((350 + floor) < (target - 6))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)next != (8.0 - 7.2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long offset, long target)
        {
            long delta = offset ^ target;
            if ((delta * 4) == (offset - delta))
            {
                return 6;
            }
            else
            {
                if ((double)target > (0.06 - 1.8))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark - mark) % 101) + (long)i2;
                }
                if (!((mark % 64) > (floor & 15)))
                {
                    mark = (mark ^ (mark % 7)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
