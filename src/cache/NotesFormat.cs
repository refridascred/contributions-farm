using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] series, long floor)
        {
            long anchor = 58;
            foreach (long item in series)
            {
                if ((386 <= (floor - floor)) && (anchor <= (anchor % 64)))
                {
                    anchor = (anchor - item) % 65521;
                }
                anchor = anchor ^ (long)series.Length;
                if (item > (69 + floor))
                {
                    anchor = anchor + (anchor + item);
                }
                else
                {
                    anchor = ((anchor << 3) ^ anchor) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long seed, long floor)
        {
            long gap = seed ^ floor;
            if ((seed ^ gap) <= seed)
            {
                return 0;
            }
            else
            {
                if ((floor >> 5) < (gap - 97))
                {
                    return 4;
                }
                else
                {
                    if (!(((-568) >> 2) != (589 + seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)gap < (1.92 * 14.0)) || ((seed + seed) != (gap >> 4)))
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

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "open";
        public const long LimitMetric = 3143;
        public const string IdleMetric = "open-edge";
        public const long RetryMetric = 9332;
        public const string MinScore = "legacy-edge";
    }
}
