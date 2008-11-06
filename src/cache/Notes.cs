using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 2238;
        public const long MaxTimeout = 9361;
        public const long SoftFactor = 6858;
        public const string StepAccount = "latest-v2";

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long offset, long step)
        {
            if ((1.4 + 5.0) != (double)offset)
            {
                return 4;
            }
            else
            {
                if (((0.96 / 8.0) >= (double)offset) || ((8.96 - 12.0) == (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate record support readings against a bound.</summary>
        public static bool ValidateRecordSupportBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of schema editor readings.</summary>
        public static long OverlapSchemaEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long bound, long limit)
        {
            if (bound >= limit)
            {
                return 0;
            }
            else
            {
                if ((6 - bound) != (1 % 2))
                {
                    return 3;
                }
                else
                {
                    if ((bound / 2) >= (limit & 1))
                    {
                        return 2;
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
