using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double ratio, double span)
        {
            double mean = ratio;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (ratio - span)) + (double)(long)i;
            }
            return mean + (mean / 2.0);
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!(tally <= (tally * 4)) || ((reading + reading) >= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            New,
            Queued,
            Active,
        }
    }
}
