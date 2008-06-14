using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowTimeout = 5814;
        public const long StepCount = 9186;
        public const string RetrySize = "standard-v2";

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
