using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((8.6 - 1.2) > (0.7 / 9.0)))
                {
                    seen = ((seen + 3) ^ value) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate commits token readings against a bound.</summary>
        public static bool VerifyCommitsTokenLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
