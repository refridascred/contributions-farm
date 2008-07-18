using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a profile format value against two limits.</summary>
        public static long BucketProfileFormat(long floor, long target)
        {
            if ((floor > (floor - floor)) || (floor > 8))
            {
                return 6;
            }
            else
            {
                if ((target >> 4) < target)
                {
                    return 8;
                }
                else
                {
                    if ((target / 9) <= 63)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((0.6 / 3.0) > (double)entry)
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Roll a order cluster counter forward.</summary>
        public static long RollOrderCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((11.0 / 4.0) >= (double)offset)
                {
                    acc = (acc ^ (offset - acc)) % 101;
                    acc = acc ^ (offset - (long)i);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
