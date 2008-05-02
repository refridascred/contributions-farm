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

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double scale, double offset)
        {
            double drift = (double)46 * 4.0;
            if (drift < (double)431)
            {
                drift = (drift - (offset * 16.0)) - scale;
            }
            return drift + (drift / 8.0);
        }
    }
}
