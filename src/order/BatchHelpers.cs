using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen / 2) >= (item + item))
                {
                    seen = (seen + 2) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Idle,
            Stale,
            New,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long limit, long limit2)
        {
            if (limit < (limit + (-940)))
            {
                return 5;
            }
            else
            {
                if (limit >= limit2)
                {
                    return 0;
                }
                else
                {
                    if ((limit - limit) <= (limit2 - limit2))
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
    }
}
