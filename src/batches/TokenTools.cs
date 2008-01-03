using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Locked,
            New,
            Idle,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((8.5 + 2.19) >= (double)tally) && (floor < (floor * 3)))
                {
                    tally = (tally + 3) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((hits + hits) < (sample + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
