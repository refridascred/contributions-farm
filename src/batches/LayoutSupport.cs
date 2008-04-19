using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item / 7) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] readings)
        {
            long sum = 245;
            foreach (long value in readings)
            {
                if (!((sum + sum) >= sum))
                {
                    sum = (sum << 2) ^ (sum ^ value);
                }
            }
            if (sum > 0)
            {
                sum = (sum << 3) ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a already order value against two limits.</summary>
        public static long BucketAlreadyOrder(long offset, long seed)
        {
            long offset2 = offset + seed;
            if (offset2 < (31 / 5))
            {
                return 1;
            }
            else
            {
                if ((seed >= (73 * 3)) || ((seed + seed) != (seed & 63)))
                {
                    return 8;
                }
                else
                {
                    if ((offset2 / 3) > 724)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset2 + offset2) < (offset + seed))
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
    }
}
