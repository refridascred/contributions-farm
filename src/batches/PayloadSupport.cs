using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            Paused,
            New,
            Retry,
            Done,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] series)
        {
            long score = 40;
            foreach (long cell in series)
            {
                if ((49 * 3) > cell)
                {
                    score = (score ^ (score & 3)) % 255;
                }
                if (((double)score == (double)cell) || ((cell - cell) < cell))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the notes payload entries that pass the check.</summary>
        public static long MeasureNotesPayloadOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((4 ^ reading) == (hits % 100)) && ((double)265 != (double)hits))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }
    }
}
