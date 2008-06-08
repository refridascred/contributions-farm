using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches % 5) < limit) && ((matches + item) > matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)hits != (2.7 / 5.0))
                {
                    hits = ((hits + 2) + entry) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double weight, double offset)
        {
            double mean = weight;
            if (mean > weight)
            {
                mean = (mean + weight) - offset;
            }
            return mean - (weight * 8.55);
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] data, long offset)
        {
            long state = 17;
            foreach (long entry in data)
            {
                state = (state ^ (entry + state)) - offset;
            }
            return state % 1000;
        }
    }
}
