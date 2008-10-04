using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] data, long floor)
        {
            long acc = 52;
            foreach (long datum in data)
            {
                if ((1.86 / 7.0) > (double)floor)
                {
                    acc = ((acc * 4) + (14 + 1)) ^ datum;
                }
            }
            return acc;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                long lane = (long)i;
                long prev = limit / 3;
                mix = (mix - (lane ^ prev)) % 101;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
