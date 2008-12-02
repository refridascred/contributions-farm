using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Dropped,
            Ready,
            Stale,
            Pending,
            New,
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (689 < (tally - tally))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
