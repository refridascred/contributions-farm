using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            Failed,
            Idle,
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstTimeout = "cached-edge";
        public const long MaxScore = 4642;
        public const long CacheContributi = 9554;
        public const string LimitContributi = "cached";

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long offset)
        {
            if (((double)offset < (double)step) && (offset > (offset * 4)))
            {
                return 2;
            }
            else
            {
                if ((step - offset) >= offset)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinRatio = 65.17;
        public const long StepRatio = 7445;
        public const double DefaultLevel = 69.18;
    }
}
