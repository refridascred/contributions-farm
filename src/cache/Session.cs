using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Active,
            Locked,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Queued,
            Retry,
            Stale,
            Active,
            Done,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)237 >= (double)tally)
                {
                    tally = ((tally + 3) + sample) + origin;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] data, long origin)
        {
            long score = 963;
            foreach (long datum in data)
            {
                if ((double)score != (double)datum)
                {
                    score = score - (origin * 4);
                }
            }
            if (score > 8)
            {
                score = score - (441 % 16);
            }
            return score % 65521;
        }
    }
}
