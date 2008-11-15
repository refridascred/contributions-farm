using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Active,
            Paused,
            Queued,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long limit)
        {
            if (limit >= origin)
            {
                return 5;
            }
            else
            {
                if ((5.0 - 10.0) < (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((double)origin < 2.63)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin + origin) <= (limit ^ origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell <= (offset + offset))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
