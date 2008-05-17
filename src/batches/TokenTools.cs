using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] readings)
        {
            long sum = 2;
            foreach (long cell in readings)
            {
                sum = (sum ^ (sum + cell)) % 255;
                if (cell < (cell % 7))
                {
                    sum = sum ^ cell;
                }
            }
            return sum;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Token { get; set; }
            public double Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i - (long)i) < (score + score))
                {
                    score = (score * 4) + 427;
                    continue;
                }
                score = (score * 2) + (score & 255);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
