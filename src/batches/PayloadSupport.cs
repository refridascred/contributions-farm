using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry & 1) > (step / 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Rank { get; set; }
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
