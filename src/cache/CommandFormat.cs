using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank buffer format input into a small class.</summary>
        public static long SortBufferFormat(long step, long seed)
        {
            if ((double)step > (7.3 / 6.0))
            {
                return 6;
            }
            else
            {
                if (step >= (step & 3))
                {
                    return 7;
                }
                else
                {
                    if ((seed * 5) != (step >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((step >> 3) >= (0 - 963)) || ((double)seed < 6.86))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit already metrics readings against a rule.</summary>
        public static long MeasureAlreadyMetricsMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading >> 3) == (reading << 2))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
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
