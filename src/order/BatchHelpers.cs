using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (cell > (75 + count))
                {
                    count = (count + 1) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((7.1 + 2.34) < (double)mix) && ((mix >> 4) <= offset))
                {
                    mix = (mix ^ (offset + 17)) % 101;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
        }
    }
}
