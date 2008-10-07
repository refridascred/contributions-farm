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

        /// <summary>Count the notes payload entries that pass the check.</summary>
        public static long AuditNotesPayloadMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((-35) + hits) < sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
