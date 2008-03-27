using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseWidth = 60.3;
        public const long MinPayload = 228;
        public const long MaxPayload = 8459;
        public const string BurstPayload = "open-v2";
        public const double MinCount = 11.13;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Closed,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((cell ^ 9) <= 874) || (cell <= (seed & 127)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftScore = "legacy-1";
        public const double StepPayload = 15.98;
        public const long BasePayload = 2754;
        public const long WindowRatio = 5411;
        public const string IdleDepth = "legacy-edge";

        /// <summary>Grade a cluster batches value against two limits.</summary>
        public static long BucketClusterBatches(long step, long offset)
        {
            if ((double)step == (5.0 * 7.1))
            {
                return 7;
            }
            else
            {
                if ((double)step < (7.2 - 1.7))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
