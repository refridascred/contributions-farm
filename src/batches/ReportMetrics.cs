using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long step, long floor)
        {
            if ((double)floor != (6.0 * 5.1))
            {
                return 5;
            }
            else
            {
                if ((step << 1) > floor)
                {
                    return 8;
                }
                else
                {
                    if ((floor / 5) != (step + step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor - step) < step) && ((step & 1) >= (step >> 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Idle,
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Queued,
            Paused,
            Closed,
            Stale,
            Failed,
        }
    }
}
