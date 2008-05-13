using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double weight, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (5.87 + weight)) + (double)(long)i;
            }
            return ratio + (weight + ratio);
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Stale,
            Ready,
            Paused,
            Idle,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((origin - reading) > reading) && ((origin ^ tally) <= (reading + (long)series.Length))) && (((reading >> 4) > tally) || ((17.0 * 2.43) < (double)reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
