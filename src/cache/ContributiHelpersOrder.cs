using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long offset, long target)
        {
            long prev = offset ^ target;
            if ((prev << 2) > (prev - 179))
            {
                return 1;
            }
            else
            {
                if (offset > (target & 255))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many profile route samples are out of range.</summary>
        public static long TallyProfileRouteOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)datum != (8.3 * 7.95))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Queued,
            New,
            Paused,
        }
    }
}
