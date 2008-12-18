using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long offset, long origin)
        {
            if (3.16 > (double)offset)
            {
                return 4;
            }
            else
            {
                if ((double)origin > 12.0)
                {
                    return 5;
                }
                else
                {
                    if (((double)origin <= (double)offset) || ((3.0 * 18.0) > (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset >> 3) != (origin + origin)) && ((8.05 + 7.2) != (double)origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Dropped,
            Closed,
            Idle,
        }
    }
}
