using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series)
        {
            long score = 350;
            foreach (long item in series)
            {
                if (((item * 5) > (score << 3)) && (78 > (score + 17)))
                {
                    score = ((score << 3) ^ (item + item)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits - value) >= (hits + 10))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + tally) == (value - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
