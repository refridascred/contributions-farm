using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (datum < (datum % 12))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen > (seen + 4))
                {
                    seen = ((seen + 3) + reading) + bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Ready,
            Dropped,
        }
    }
}
