using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 1434;
        public const long MaxRatio = 7146;
        public const double RetryCommand = 72.89;
        public const double IdleFactor = 50.33;
        public const long MinScore = 4662;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)619 >= (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
