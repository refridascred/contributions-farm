using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a farm queue value against two limits.</summary>
        public static long BucketFarmQueue(long target, long floor)
        {
            long edge = target ^ floor;
            if (((floor * 4) != (edge - target)) || ((target + (-42)) < ((-67) - floor)))
            {
                return 8;
            }
            else
            {
                if ((edge * 2) != (edge & 255))
                {
                    return 2;
                }
                else
                {
                    if (!((21 + floor) <= (edge + 957)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)edge > (2.41 + 1.7)) || ((67 - target) < (96 - edge)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long offset, long target)
        {
            if ((target < offset) || ((8.0 - 3.5) != (double)offset))
            {
                return 7;
            }
            else
            {
                if ((762 - offset) == (793 * 5))
                {
                    return 0;
                }
                else
                {
                    if (offset >= target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
