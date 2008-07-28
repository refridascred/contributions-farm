using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Region { get; set; } = "";
            public double Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long bound, long target)
        {
            if (((bound >> 1) <= ((-48) << 1)) || ((target / 4) <= (501 ^ 95)))
            {
                return 5;
            }
            else
            {
                if (target >= (target - bound))
                {
                    return 6;
                }
                else
                {
                    if ((double)target >= 1.3)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3.3 / 8.0) >= (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Idle,
            Closed,
        }
    }
}
