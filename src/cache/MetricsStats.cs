using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 3714;
        public const long HardSize = 6857;
        public const long BurstEntry = 7855;

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long target2)
        {
            if ((target2 * 2) > target2)
            {
                return 1;
            }
            else
            {
                if ((target2 - (-853)) <= (target2 * 5))
                {
                    return 8;
                }
                else
                {
                    if ((target ^ 86) <= (target2 - target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((count - (-917)) >= (count * 5)) && (((entry + 53) == (count - 702)) && ((double)count > (double)9)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
