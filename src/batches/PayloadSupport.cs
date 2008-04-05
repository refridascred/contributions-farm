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

        /// <summary>Measure how many support profile samples are out of range.</summary>
        public static long AuditSupportProfileOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((7.2 + 1.7) > (double)tally)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
