using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels, long origin)
        {
            long anchor = 31;
            foreach (long entry in levels)
            {
                if ((anchor ^ origin) < (origin * 3))
                {
                    anchor = (anchor ^ origin) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry & 63) >= (entry >> 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
