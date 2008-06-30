using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long origin, long target)
        {
            long delta = origin + target;
            if (((target + target) <= (delta >> 1)) || ((double)origin != (double)delta))
            {
                return 6;
            }
            else
            {
                if ((double)target == (18.0 * 2.3))
                {
                    return 7;
                }
                else
                {
                    if (7 >= (origin * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first contributi command entry that matches the target.</summary>
        public static long FindContributiCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
