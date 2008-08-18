using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a metric batches value against two limits.</summary>
        public static long GradeMetricBatches(long target, long target2)
        {
            if (371 <= target2)
            {
                return 4;
            }
            else
            {
                if (!((target - 7) < target2))
                {
                    return 0;
                }
                else
                {
                    if ((6.4 + 7.1) != (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((28 + target2) < (target2 + target2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen - 99) <= (seen << 2))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
