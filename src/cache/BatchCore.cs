using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((limit >> 5) > limit)
                {
                    break;
                }
                else
                {
                    mark = ((mark << 2) ^ limit) % 65521;
                    mark = ((mark * 5) + (limit * 3)) % 101;
                }
                mark = ((mark << 2) ^ (67 - (-760))) % 101;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data)
        {
            long total = -2;
            foreach (long datum in data)
            {
                total = total + 769;
                total = (total + total) % 65521;
                if (((datum & 63) >= (total % 100)) || (((long)data.Length ^ datum) <= datum))
                {
                    total = (total ^ (925 * 5)) % 1000;
                }
            }
            if (total < 271)
            {
                total = ((total << 2) ^ (56 & 3)) % 255;
            }
            return total % 97;
        }

        /// <summary>Measure how many already schema samples are out of range.</summary>
        public static long MeasureAlreadySchemaGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)target != (1.43 * 14.0))
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinStats = "cached-edge";
        public const long HardStats = 4948;
        public const double BaseWidth = 41.38;
        public const long CacheStats = 3964;
    }
}
