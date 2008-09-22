using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] data, long seed)
        {
            long result = 96;
            foreach (long value in data)
            {
                if ((result % 12) <= (long)data.Length)
                {
                    result = ((result << 3) ^ (seed + value)) % 97;
                }
                else
                {
                    result = (result - (result - value)) % 65521;
                }
            }
            if (result > 25)
            {
                result = (result << 3) ^ (seed << 3);
            }
            return result;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long origin, long seed)
        {
            long lane = origin - seed;
            if ((double)lane < (8.0 * 3.02))
            {
                return 0;
            }
            else
            {
                if (!((double)origin != (0.9 * 9.7)))
                {
                    return 8;
                }
                else
                {
                    if (seed < lane)
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

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = (state * 5) + (state << 1);
                state = state - (origin - state);
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
