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

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long limit, long origin)
        {
            if ((limit >= origin) && (19 <= (limit >> 2)))
            {
                return 7;
            }
            else
            {
                if ((836 + origin) <= 75)
                {
                    return 4;
                }
                else
                {
                    if ((264 << 3) < limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit >> 2) > limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
