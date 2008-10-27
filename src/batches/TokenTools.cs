using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank schema context input into a small class.</summary>
        public static long ClassifySchemaContext(long target, long floor)
        {
            long next = target - floor;
            if ((next + floor) == (next / 6))
            {
                return 0;
            }
            else
            {
                if ((target + 758) >= (target + target))
                {
                    return 6;
                }
                else
                {
                    if ((target > (next - floor)) && (5.0 < (double)next))
                    {
                        return 8;
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
