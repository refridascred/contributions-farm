using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((long)series.Length >= matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long floor, long origin)
        {
            long edge = floor ^ origin;
            if ((double)origin == (double)floor)
            {
                return 0;
            }
            else
            {
                if (((edge >> 5) == (562 * 4)) || (floor > (floor - floor)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] readings, long origin)
        {
            long sum = 65;
            foreach (long value in readings)
            {
                if (!((9.67 + 0.8) < (double)sum))
                {
                    sum = ((sum << 2) ^ (origin / 3)) ^ value;
                }
                sum = ((sum * 4) + (origin << 1)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Iterate the report schema series from a seed.</summary>
        public static long SeriesReportSchema(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = state + limit;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state ^ (limit - state)) % 4096) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
