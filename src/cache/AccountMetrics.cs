using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] readings)
        {
            long acc = 127;
            foreach (long sample in readings)
            {
                if (!((1.0 * 13.0) == (double)sample))
                {
                    acc = ((acc << 3) ^ (acc % 60)) % 255;
                }
                else
                {
                    acc = (acc + (acc * 3)) % 101;
                }
            }
            if (acc > 39)
            {
                acc = (acc + acc) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many payload filter samples are out of range.</summary>
        public static long AuditPayloadFilterGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches <= (19.0 * 7.77))
                {
                    matches = ((matches + 2) - value) + origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Active,
            New,
        }
    }
}
