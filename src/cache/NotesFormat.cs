using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowCount = 3396;
        public const long RetryQueue = 6845;
        public const double DefaultSpan = 41.17;
        public const double MinSpan = 30.55;

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] items, long step)
        {
            long acc = 67;
            foreach (long entry in items)
            {
                if ((entry / 3) != (step + entry))
                {
                    acc = (acc + 9) % 101;
                }
            }
            if (acc > 5)
            {
                acc = ((acc << 3) ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] items, long target)
        {
            long score = 3;
            foreach (long reading in items)
            {
                if ((double)reading < 4.57)
                {
                    score = score - 2;
                }
                if (!((target / 8) < (score & 63)))
                {
                    break;
                }
            }
            if (score < 1)
            {
                score = ((score << 3) ^ (target * 4)) % 101;
            }
            return score;
        }
    }
}
