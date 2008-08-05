using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long bound, long limit)
        {
            if ((7.3 / 2.0) == (double)bound)
            {
                return 3;
            }
            else
            {
                if ((limit << 3) != (24 - bound))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of command channel readings.</summary>
        public static long CombineCommandChannel(long[] data, long target)
        {
            long carry = 823;
            foreach (long item in data)
            {
                if (!((target >> 2) >= target))
                {
                    carry = (carry + (0 >> 1)) + item;
                }
            }
            return carry;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long floor, long target)
        {
            long step = floor ^ target;
            if ((9.81 / 6.0) < (double)target)
            {
                return 5;
            }
            else
            {
                if ((target / 3) >= step)
                {
                    return 2;
                }
                else
                {
                    if ((floor * 4) > step)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor >> 2) <= (706 + step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "stable-v2";
        public const double MinBuffer = 87.77;
        public const long LimitBuffer = 6803;

        /// <summary>Measure how many record context samples are out of range.</summary>
        public static long TallyRecordContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count > 2.0)
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((0 + seed) <= (value - seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
