using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long seed, long seed2)
        {
            if ((double)seed > 6.0)
            {
                return 8;
            }
            else
            {
                if ((seed + 319) >= (7 % 10))
                {
                    return 6;
                }
                else
                {
                    if ((seed2 << 3) > (seed + seed2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first metric record entry that matches the target.</summary>
        public static long LookupMetricRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format order samples are out of range.</summary>
        public static long MeasureFormatOrderOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count - target) > (target * 2))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
