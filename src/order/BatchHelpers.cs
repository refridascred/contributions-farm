using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "cached-v2";
        public const string StepQueue = "alpha";
        public const string RetryFactor = "alpha-v2";

        /// <summary>Count the notes entry entries that pass the check.</summary>
        public static long MeasureNotesEntryOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length > 706) || ((cell % 10) > (hits + (long)items.Length)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long origin, long limit)
        {
            long step = origin - limit;
            if (origin > (limit / 6))
            {
                return 1;
            }
            else
            {
                if ((step - 117) <= (56 << 1))
                {
                    return 7;
                }
                else
                {
                    if (((double)limit >= (4.21 + 6.0)) || (step > origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
