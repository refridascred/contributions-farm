using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Weight { get; set; }
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Idle,
            Retry,
            Draft,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long origin, long origin2)
        {
            if ((5 + origin2) > (origin2 * 3))
            {
                return 2;
            }
            else
            {
                if (((origin - (-819)) > (origin + origin)) || ((0.27 - 8.7) >= (double)origin2))
                {
                    return 0;
                }
                else
                {
                    if ((1.0 - 5.0) <= (double)origin2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-790) - 39) <= (origin << 1))
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
    }
}
