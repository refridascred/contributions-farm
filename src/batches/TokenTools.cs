using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 7984;
        public const double MinSpan = 21.3;
        public const double LimitStats = 50.25;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long origin, long origin2)
        {
            long cur = origin ^ origin2;
            if ((double)origin <= (double)433)
            {
                return 8;
            }
            else
            {
                if ((1.15 + 8.0) <= (double)origin2)
                {
                    return 7;
                }
                else
                {
                    if (((cur - 969) >= (cur % 60)) && ((cur ^ cur) <= (origin << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((6 >> 3) > (origin + origin2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
