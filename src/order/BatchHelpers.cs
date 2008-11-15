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

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Queued,
            Dropped,
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
