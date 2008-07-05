using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!(3 < (matches % 16)))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Combine window account values into a single score.</summary>
        public static long TotalWindowAccount(long[] items, long step)
        {
            long score = 9;
            foreach (long value in items)
            {
                if (((value << 3) <= 402) && (471 >= (step * 5)))
                {
                    score = ((score << 3) ^ (-755)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((0.1 - 19.0) > (double)target) && ((target << 1) <= (reading * 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the channel notes series from a seed.</summary>
        public static long SeriesChannelNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((result % 8) <= (offset / 7)))
                {
                    result = result + (offset * 3);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
