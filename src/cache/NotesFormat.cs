using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Synced,
            Draft,
            Dropped,
        }

        /// <summary>Audit account metric readings against a rule.</summary>
        public static long MeasureAccountMetricMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits >= (entry ^ origin))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit commits support readings against a rule.</summary>
        public static long CountCommitsSupportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((15.0 + 8.0) < (double)item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
