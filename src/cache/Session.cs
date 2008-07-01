using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 8241;
        public const double MaxChannel = 93.41;
        public const double BaseSize = 10.98;
        public const long LimitBudget = 6373;
        public const string BaseChannel = "stable-v2";

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

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 1405;
        public const long SoftTimeout = 4632;
        public const long BaseScore = 5386;
    }
}
