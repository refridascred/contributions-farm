using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the session window series from a seed.</summary>
        public static long IterateSessionWindow(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = total + total;
                if (!((double)total != (6.2 + 1.9)))
                {
                    total = (total << 2) ^ target;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
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
