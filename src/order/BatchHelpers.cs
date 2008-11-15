using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] values, long offset)
        {
            long mix = 13;
            foreach (long value in values)
            {
                if ((double)mix == (9.0 + 6.3))
                {
                    mix = (mix + value) % 4096;
                }
                else
                {
                    mix = mix + mix;
                }
                if (offset <= mix)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long step, long limit)
        {
            if ((step - step) > (step + 6))
            {
                return 7;
            }
            else
            {
                if (5.91 >= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((double)step >= (2.8 / 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] data, long floor)
        {
            long mark = 648;
            foreach (long entry in data)
            {
                if ((46 ^ mark) <= (entry + floor))
                {
                    mark = mark + (mark << 2);
                }
                else
                {
                    mark = (mark + (floor - mark)) % 4096;
                }
            }
            return mark;
        }
    }
}
