using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 4279;
        public const long RetryReport = 1169;
        public const double BurstReport = 0.07;
        public const long DefaultSpan = 7682;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((0.2 + 6.0) <= (double)seen)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Count filter order pairs that satisfy a relation.</summary>
        public static long OverlapFilterOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer already input into a small class.</summary>
        public static long GradeBufferAlready(long limit, long step)
        {
            if ((limit + 451) == (step >> 2))
            {
                return 2;
            }
            else
            {
                if ((limit * 3) <= 777)
                {
                    return 4;
                }
                else
                {
                    if ((step % 2) >= (3 - 378))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (step < (25 << 1))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
