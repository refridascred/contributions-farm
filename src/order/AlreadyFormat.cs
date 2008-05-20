using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every metric already entry stays within the limit.</summary>
        public static bool GuardMetricAlreadyRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Failed,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long floor, long target)
        {
            if ((target * 2) <= (target + 72))
            {
                return 8;
            }
            else
            {
                if (!((target * 2) <= (floor >> 3)))
                {
                    return 0;
                }
                else
                {
                    if ((floor <= (floor & 15)) || ((double)floor == (4.9 + 7.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor < 199) && ((double)floor >= 7.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Pending,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
        }
    }
}
