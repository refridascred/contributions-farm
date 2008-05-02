using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading + seen) < (7 / 4))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = total - total;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
