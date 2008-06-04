using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the tools stats entries that pass the check.</summary>
        public static long MeasureToolsStatsHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (0.9 > (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((double)62 < (double)sample) || (5 > (matches - (long)levels.Length)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                score = score ^ (score >> 2);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
