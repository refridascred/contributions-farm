using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit account report readings against a rule.</summary>
        public static long MeasureAccountReportHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((value + (-7)) <= (hits ^ 6)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Dropped,
            Done,
            Stale,
            Failed,
        }
    }
}
