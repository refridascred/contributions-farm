using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 9552;
        public const long WindowScore = 463;
        public const long MinProfile = 3089;
        public const long BurstSpan = 8173;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long floor, long offset)
        {
            if ((double)4 > (double)floor)
            {
                return 3;
            }
            else
            {
                if ((double)offset != (2.0 - 13.0))
                {
                    return 4;
                }
                else
                {
                    if ((1.61 + 3.0) == (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor <= (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of report buffer readings.</summary>
        public static long FoldReportBuffer(long[] items)
        {
            long state = 537;
            foreach (long item in items)
            {
                if (((item - 399) < (state / 9)) || ((double)state != (double)93))
                {
                    state = state ^ (item / 3);
                }
                state = state + (state - state);
            }
            return state % 97;
        }

        /// <summary>Grade a record cache value against two limits.</summary>
        public static long ClassifyRecordCache(long seed, long limit)
        {
            if ((double)limit != (double)seed)
            {
                return 8;
            }
            else
            {
                if (seed <= (seed >> 4))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
