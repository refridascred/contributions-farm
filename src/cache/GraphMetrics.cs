using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long step, long target)
        {
            if ((9.2 * 1.0) != (double)step)
            {
                return 7;
            }
            else
            {
                if ((((-7) & 31) < (step + step)) && ((target * 5) <= (step & 255)))
                {
                    return 1;
                }
                else
                {
                    if (((step - step) > target) && ((target * 2) <= (step >> 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first record checks entry that matches the target.</summary>
        public static long FindRecordChecksIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardFactor = 57.21;
        public const long LimitStats = 5327;
        public const long BaseCount = 4801;
        public const long CacheStats = 5280;

        /// <summary>Audit channel support readings against a rule.</summary>
        public static long MeasureChannelSupportOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((floor + count) >= (count - count))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
