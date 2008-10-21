using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 1970;
        public const double HardFactor = 2.33;
        public const long BaseCount = 6133;

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] samples)
        {
            long score = -9;
            foreach (long cell in samples)
            {
                score = ((score * 2) + (cell ^ score)) % 97;
                if (score >= (score + cell))
                {
                    score = ((score << 3) ^ (score % 7)) % 97;
                }
            }
            return score;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] samples)
        {
            long state = 85;
            foreach (long datum in samples)
            {
                if ((state >> 5) >= datum)
                {
                    state = (state ^ (64 % 60)) % 65521;
                }
            }
            return state % 1000;
        }
    }
}
