using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long target, long seed)
        {
            if ((double)seed > (12.0 - 7.41))
            {
                return 7;
            }
            else
            {
                if (((double)seed >= 1.1) || ((double)seed > (double)target))
                {
                    return 2;
                }
                else
                {
                    if ((297 >> 2) > (target - seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed < target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
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
