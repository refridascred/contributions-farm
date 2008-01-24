using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long floor, long step)
        {
            if ((double)step < (2.71 + 5.7))
            {
                return 7;
            }
            else
            {
                if ((230 ^ floor) > (step - 601))
                {
                    return 6;
                }
                else
                {
                    if ((floor + (-8)) < (step % 97))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((1 ^ floor) >= 104)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Retry,
            Pending,
            Paused,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheScore = 1113;
        public const long SoftEditor = 7265;
        public const double BaseEditor = 89.88;
    }
}
