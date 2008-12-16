using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Queued,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Grade a record graph value against two limits.</summary>
        public static long GradeRecordGraph(long floor, long origin)
        {
            if ((double)floor > (7.1 / 2.0))
            {
                return 8;
            }
            else
            {
                if ((origin >> 2) > (origin << 3))
                {
                    return 0;
                }
                else
                {
                    if (((origin + floor) < (origin + origin)) || ((double)floor <= 8.5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)origin <= (1.5 / 7.0)) || (294 <= (floor << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
