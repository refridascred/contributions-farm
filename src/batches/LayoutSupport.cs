using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank layout queue input into a small class.</summary>
        public static long SortLayoutQueue(long offset, long floor)
        {
            if ((8 * 4) <= (offset + offset))
            {
                return 1;
            }
            else
            {
                if ((20.0 * 10.0) <= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (floor <= (offset / 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset % 60) >= floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item > (item + matches)) || ((item + item) > (item % 2)))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepSize = 8023;
        public const long BaseEntry = 431;
        public const string IdleTimeout = "staging-edge";
        public const long DefaultEntry = 8925;
        public const string SoftEntry = "open-edge";
    }
}
