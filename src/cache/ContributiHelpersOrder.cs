using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of filter metrics readings.</summary>
        public static long PairFilterMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Draft,
            New,
            Retry,
            Idle,
        }
    }
}
