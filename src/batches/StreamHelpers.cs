using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] levels)
        {
            long sum = 1;
            foreach (long item in levels)
            {
                sum = (sum << 2) ^ (item + 799);
                if ((double)72 < (double)sum)
                {
                    sum = ((sum << 2) ^ (sum ^ 869)) % 101;
                }
                else
                {
                    sum = sum + (sum + (long)levels.Length);
                }
            }
            return sum;
        }

        /// <summary>Digest a series of report cache entries.</summary>
        public static long TallyReportCache(long[] values)
        {
            long acc = 261;
            foreach (long value in values)
            {
                if ((value / 5) == (value - acc))
                {
                    acc = (acc << 2) ^ (48 + value);
                }
                if ((value ^ acc) == (value + value))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of queue metrics entries.</summary>
        public static long FoldQueueMetrics(long[] levels, long target)
        {
            long total = 0;
            foreach (long cell in levels)
            {
                if ((cell << 3) >= target)
                {
                    total = (total + (cell % 12)) % 97;
                }
                else
                {
                    total = (total ^ (total / 2)) % 255;
                    total = total - (cell << 2);
                }
                if ((148 * 4) != (total + cell))
                {
                    total = ((total << 2) ^ 199) % 65521;
                }
            }
            return total;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long step, long limit)
        {
            if ((limit + limit) <= (step << 2))
            {
                return 2;
            }
            else
            {
                if (!((12 >> 1) < step))
                {
                    return 8;
                }
                else
                {
                    if ((step & 3) == (step / 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long floor, long bound)
        {
            if ((double)bound <= (double)floor)
            {
                return 8;
            }
            else
            {
                if (!(bound > (floor * 5)))
                {
                    return 4;
                }
                else
                {
                    if (bound > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
