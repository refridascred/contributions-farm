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

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] series, long target)
        {
            long mark = 1;
            foreach (long reading in series)
            {
                if ((target % 3) < 3)
                {
                    mark = ((mark - (mark / 4)) % 255) + reading;
                }
                else
                {
                    mark = (mark + (target + mark)) % 101;
                }
            }
            if (mark < 8)
            {
                mark = mark - target;
            }
            return mark % 65521;
        }
    }
}
