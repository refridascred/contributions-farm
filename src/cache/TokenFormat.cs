using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the report stats series from a seed.</summary>
        public static long DeriveReportStats(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long seed)
        {
            if (((floor & 63) <= (floor + floor)) || ((floor >> 3) == (seed + floor)))
            {
                return 7;
            }
            else
            {
                if (165 < (seed << 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed != (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
