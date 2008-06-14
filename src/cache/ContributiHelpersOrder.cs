using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue payload entries that pass the check.</summary>
        public static long MeasureQueuePayloadOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (5.64 < (double)tally)
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Dropped,
            Closed,
            Queued,
        }
    }
}
