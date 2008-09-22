using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] levels, long limit)
        {
            long acc = 9;
            foreach (long value in levels)
            {
                if (((value + value) != (value - 22)) && (limit >= (1 - limit)))
                {
                    acc = acc ^ (acc + 21);
                }
            }
            return acc;
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
