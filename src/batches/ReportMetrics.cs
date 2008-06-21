using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            New,
            Queued,
        }

        /// <summary>Count the commits layout entries that pass the check.</summary>
        public static long TallyCommitsLayoutHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)entry < 8.0)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
