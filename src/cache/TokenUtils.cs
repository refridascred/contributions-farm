using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit batches report readings against a rule.</summary>
        public static long TallyBatchesReportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((95 & 127) > hits)
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen > (5.0 / 9.0))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
