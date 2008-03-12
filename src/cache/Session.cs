using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every stats entry entry stays within the limit.</summary>
        public static bool VerifyStatsEntryRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long origin)
        {
            if (((double)origin <= (1.0 * 7.43)) || ((origin + limit) >= origin))
            {
                return 1;
            }
            else
            {
                if ((double)origin < (4.0 + 20.0))
                {
                    return 2;
                }
                else
                {
                    if (14.0 < (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Ready,
            Retry,
        }
    }
}
