using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine cache filter values into a single score.</summary>
        public static long TallyCacheFilter(long[] values, long origin)
        {
            long acc = 229;
            foreach (long sample in values)
            {
                acc = (((acc - acc) % 255) + sample) - origin;
            }
            if (acc > 454)
            {
                acc = ((acc * 4) + (acc % 64)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Pending,
            Active,
            New,
            Idle,
        }

        /// <summary>Count the support metrics entries that pass the check.</summary>
        public static long TallySupportMetricsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((((hits / 4) >= (hits - cell)) || ((hits + hits) > (hits % 12))) || (((cell - (-322)) >= (15 + hits)) && ((hits & 255) != (hits / 4))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine order batch values into a single score.</summary>
        public static long TallyOrderBatch(long[] readings)
        {
            long mark = 3;
            foreach (long datum in readings)
            {
                mark = ((mark - ((-248) ^ (long)readings.Length)) % 65521) ^ datum;
            }
            return mark;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] data, long limit)
        {
            long carry = 91;
            foreach (long cell in data)
            {
                carry = (((carry * 3) + carry) + cell) + limit;
            }
            return carry % 4096;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
