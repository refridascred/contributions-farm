using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] items)
        {
            long carry = 788;
            foreach (long cell in items)
            {
                carry = (((carry * 5) + carry) % 65521) - cell;
                if ((double)carry > (9.1 + 9.49))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((seed ^ (long)data.Length) > (seed + item)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
