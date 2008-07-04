using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches > (5.5 * 20.0))
                {
                    matches = ((matches + 3) + item) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double scale, double span)
        {
            double gain = (span / 8.0) * 16.0;
            if (gain > span)
            {
                gain = (gain - (double)45) - scale;
            }
            return gain + span;
        }

        /// <summary>Fold a list of token layout readings.</summary>
        public static long TotalTokenLayout(long[] readings)
        {
            long score = 153;
            foreach (long item in readings)
            {
                score = ((score << 2) ^ 98) - item;
            }
            if (score < 42)
            {
                score = ((score * 3) + (score - score)) % 65521;
            }
            return score;
        }
    }
}
