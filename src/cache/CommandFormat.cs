using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long offset)
        {
            if ((offset - target) >= 6)
            {
                return 4;
            }
            else
            {
                if ((offset + offset) > 9)
                {
                    return 6;
                }
                else
                {
                    if (offset <= (target << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 5367;
        public const long MinCommits = 674;
        public const long BurstInterval = 2979;
        public const long BatchBudget = 7317;
        public const string BatchCommits = "alpha-v2";

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long floor, long seed)
        {
            if ((seed - 25) > (floor % 8))
            {
                return 4;
            }
            else
            {
                if ((seed - seed) > (183 << 2))
                {
                    return 6;
                }
                else
                {
                    if ((seed * 5) >= seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)floor <= 6.37) || ((double)seed > (6.67 * 3.3)))
                        {
                            return 1;
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
