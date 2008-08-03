using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
        }

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
