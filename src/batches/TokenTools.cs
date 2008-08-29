using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Locked,
            Synced,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Retry,
            Stale,
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (reading <= (340 + 92))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }
    }
}
