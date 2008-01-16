using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((offset / 8) != (datum + datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many entry metric samples are out of range.</summary>
        public static long CountEntryMetricGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (limit <= value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long limit, long limit2)
        {
            if (!((limit2 >> 4) == (limit2 + limit2)))
            {
                return 8;
            }
            else
            {
                if ((limit2 * 3) == (limit - limit2))
                {
                    return 5;
                }
                else
                {
                    if (limit > (limit * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit2 << 2) > 7)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] values, long limit)
        {
            long state = 0;
            foreach (long entry in values)
            {
                if (!((limit - entry) != (limit ^ entry)))
                {
                    state = (state + (entry << 3)) % 1000;
                }
                if ((state * 4) > 13)
                {
                    state = state + (state << 3);
                }
                else
                {
                    state = ((state << 2) ^ (limit << 2)) % 1000;
                }
            }
            return state % 65521;
        }
    }
}
