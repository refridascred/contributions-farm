using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate profile route readings against a bound.</summary>
        public static bool VerifyProfileRouteBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Classify a report support pair into a bucket.</summary>
        public static long GradeReportSupport(long bound, long floor)
        {
            if (!((floor + floor) >= floor))
            {
                return 0;
            }
            else
            {
                if (((floor >> 5) > floor) || ((8.0 - 14.0) < (7.09 - 11.0)))
                {
                    return 3;
                }
                else
                {
                    if (3.1 > (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Draft,
            Failed,
            Paused,
        }
    }
}
