using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long seed, long limit)
        {
            if ((double)limit >= (2.49 / 3.0))
            {
                return 4;
            }
            else
            {
                if (limit <= seed)
                {
                    return 0;
                }
                else
                {
                    if ((66 ^ seed) > (455 % 16))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double gain, double floor)
        {
            double weight = (floor - gain) * 4.74;
            if (weight > weight)
            {
                weight = weight - (gain / 4.0);
            }
            else
            {
                weight = weight - 6.23;
            }
            return weight - floor;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long floor, long limit)
        {
            long cur = floor + limit;
            if (((20.0 - 15.0) != (double)limit) || ((floor + limit) >= 180))
            {
                return 2;
            }
            else
            {
                if (8.1 <= (double)cur)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Label { get; set; }
            public double Total { get; set; }
            public long Stamp { get; set; }
        }
    }
}
