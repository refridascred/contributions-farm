using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a format contributi value against two limits.</summary>
        public static long GradeFormatContributi(long seed, long bound)
        {
            long bound2 = seed ^ bound;
            if (bound2 >= (seed - bound2))
            {
                return 0;
            }
            else
            {
                if ((double)seed >= (5.65 + 20.0))
                {
                    return 5;
                }
                else
                {
                    if (!((2.22 + 7.0) > (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            Stale,
            New,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            New,
            Dropped,
        }
    }
}
