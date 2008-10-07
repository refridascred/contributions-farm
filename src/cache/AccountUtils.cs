using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] items, long seed)
        {
            long score = 473;
            foreach (long datum in items)
            {
                if (((2 - datum) > (datum % 8)) || ((datum ^ datum) <= (datum & 3)))
                {
                    score = (score << 2) ^ (score / 2);
                }
                if (((-6) + seed) > seed)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftSize = 94.09;
        public const long IdleSize = 6543;
        public const string MinScore = "legacy-1";
        public const long SoftSpan = 4511;

        /// <summary>Measure how many channel report samples are out of range.</summary>
        public static long TallyChannelReportHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)matches <= (0.5 - 2.45))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }
    }
}
