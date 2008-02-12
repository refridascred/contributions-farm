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

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Stale,
            Ready,
            Locked,
            Retry,
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
