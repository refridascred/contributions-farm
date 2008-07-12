using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Retry,
            Draft,
            New,
            Idle,
            Failed,
        }

        /// <summary>Measure how many notes batch samples are out of range.</summary>
        public static long TallyNotesBatchHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((datum ^ hits) >= (datum >> 4)) && (((hits / 9) == (12 - hits)) || ((double)hits != (3.1 / 2.0))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
