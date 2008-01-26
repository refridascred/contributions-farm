using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long floor, long origin)
        {
            if (((origin & 1) != (origin % 12)) || (6 <= (floor + floor)))
            {
                return 5;
            }
            else
            {
                if ((origin >> 3) == (origin - floor))
                {
                    return 7;
                }
                else
                {
                    if ((-9) <= (origin - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Stale,
            Synced,
            Retry,
        }
    }
}
