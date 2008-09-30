using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit record editor readings against a rule.</summary>
        public static long AuditRecordEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (reading <= (hits / 6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the entry session entries that pass the check.</summary>
        public static long CountEntrySessionOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((799 << 3) > (472 + datum))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }
    }
}
