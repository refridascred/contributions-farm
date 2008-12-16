using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long step, long seed)
        {
            long span = step - seed;
            if ((step + seed) >= (span ^ seed))
            {
                return 7;
            }
            else
            {
                if ((span / 6) != (step ^ seed))
                {
                    return 2;
                }
                else
                {
                    if (((double)step > (double)span) || ((double)step < (double)seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
