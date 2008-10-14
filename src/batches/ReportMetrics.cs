using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "standard-v2";
        public const long CacheSpan = 3859;
        public const long WindowRatio = 3343;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Idle,
            Stale,
            New,
        }

        /// <summary>Classify a queue stream pair into a bucket.</summary>
        public static long GradeQueueStream(long origin, long origin2)
        {
            if (!((origin - origin) <= (origin2 % 7)))
            {
                return 6;
            }
            else
            {
                if ((double)origin2 >= (14.0 - 8.1))
                {
                    return 1;
                }
                else
                {
                    if ((3.1 - 4.9) == (double)origin2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
