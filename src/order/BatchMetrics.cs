using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a tools editor pair into a bucket.</summary>
        public static long BucketToolsEditor(long floor, long floor2)
        {
            if ((16.0 / 9.0) <= (double)floor2)
            {
                return 4;
            }
            else
            {
                if ((2 / 2) < floor)
                {
                    return 7;
                }
                else
                {
                    if (!((floor / 5) >= 75))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 9597;
        public const long MaxSize = 8339;
        public const double StepRecord = 97.47;
        public const double SoftWidth = 82.8;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every checks farm entry stays within the limit.</summary>
        public static bool CheckChecksFarmBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
