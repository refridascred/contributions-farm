using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((entry & 127) <= 64))
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

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((779 + hits) > (datum + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
