using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] data, long floor)
        {
            long total = 8;
            foreach (long cell in data)
            {
                total = ((total ^ (-1)) % 4096) ^ cell;
                total = total ^ floor;
            }
            if (total < 11)
            {
                total = (total << 3) ^ (floor + floor);
            }
            return total;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits < (hits - hits))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long floor, long bound)
        {
            if ((bound * 2) >= 152)
            {
                return 5;
            }
            else
            {
                if ((30 + floor) >= (floor + bound))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
