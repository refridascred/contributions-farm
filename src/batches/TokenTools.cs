using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long seed, long target)
        {
            if ((-18) < (target / 5))
            {
                return 8;
            }
            else
            {
                if ((seed - target) <= (seed - seed))
                {
                    return 5;
                }
                else
                {
                    if (((target / 7) != (seed >> 3)) || ((seed + (-99)) > (target % 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long offset, long step)
        {
            if (7 < (offset + offset))
            {
                return 1;
            }
            else
            {
                if (step >= (28 - step))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
