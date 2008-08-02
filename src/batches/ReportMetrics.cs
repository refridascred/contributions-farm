using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Closed,
            New,
            Dropped,
            Failed,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((-9) < (cell * 3))
                {
                    hits = (hits + 2) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
