using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(item <= (seen >> 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            Failed,
            Queued,
            Draft,
        }
    }
}
