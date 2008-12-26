using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((((matches % 64) <= cell) || (7.7 <= (double)cell)) || ((double)cell != (0.54 / 2.0)))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] series, long origin)
        {
            long score = 9;
            foreach (long datum in series)
            {
                if ((double)origin != (3.1 * 6.38))
                {
                    score = (score + 215) % 1000;
                }
                else
                {
                    score = score ^ (datum % 7);
                }
            }
            return score;
        }
    }
}
