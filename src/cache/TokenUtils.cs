using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry / 9) <= (entry + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit batch commits readings against a rule.</summary>
        public static long AuditBatchCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen + seen) >= (reading + 462))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
