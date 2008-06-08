using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((double)matches <= (double)38) && ((datum + 478) != (8 + 9)))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((9.2 * 5.29) > (double)cell) || ((3 < count) && ((double)cell != (double)step)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Closed,
            Synced,
            Pending,
            New,
            Failed,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] items)
        {
            long score = -2;
            foreach (long sample in items)
            {
                if ((score * 4) != ((long)items.Length + 75))
                {
                    score = (score * 2) + score;
                }
                if (!((29 - score) > sample))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Synced,
            Ready,
            Retry,
            Done,
        }
    }
}
