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

        /// <summary>Combine entry order values into a single score.</summary>
        public static long DigestEntryOrder(long[] readings)
        {
            long acc = 320;
            foreach (long value in readings)
            {
                acc = (acc - (acc + acc)) ^ value;
            }
            if (acc < 5)
            {
                acc = acc ^ (acc ^ 5);
            }
            return acc;
        }
    }
}
