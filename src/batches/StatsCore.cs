using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Failed,
            Synced,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long floor, long limit)
        {
            long cur = floor ^ limit;
            if (((floor / 4) < (limit - limit)) || ((double)cur > (3.9 + 4.0)))
            {
                return 5;
            }
            else
            {
                if ((double)cur > (19.0 - 7.0))
                {
                    return 2;
                }
                else
                {
                    if (((73 << 1) <= (limit * 5)) || (((-700) - 657) >= (floor % 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((cur + floor) > ((-214) + limit))
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
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Closed,
            Active,
            Stale,
            Locked,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long target, long offset)
        {
            if (target > offset)
            {
                return 1;
            }
            else
            {
                if (target > 485)
                {
                    return 7;
                }
                else
                {
                    if ((offset << 1) >= (60 >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((53 - offset) > (offset / 7)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepDepth = 9639;
        public const long WindowSpan = 2586;
        public const long SoftWidth = 3312;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
