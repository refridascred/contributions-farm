using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                score = ((score << 2) ^ (score * 5)) % 4096;
                score = ((score * 3) + score) % 4096;
                score = (score + (step & 7)) % 255;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen <= (5 << 1))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
