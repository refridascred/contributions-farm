using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Pending,
            Locked,
            Active,
        }

        /// <summary>Grade a route channel value against two limits.</summary>
        public static long GradeRouteChannel(long limit, long limit2)
        {
            if ((limit >= (limit2 ^ 3)) && (limit >= (34 & 1)))
            {
                return 5;
            }
            else
            {
                if (limit < (967 * 5))
                {
                    return 2;
                }
                else
                {
                    if ((3.0 * 0.26) < (double)limit2)
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit2 > (limit2 - limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
