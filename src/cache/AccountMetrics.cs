using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 70.81;
        public const long IdleEntry = 8676;
        public const long LimitCount = 5810;
        public const long BatchSize = 780;

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 3510;
        public const long MaxCount = 2468;
        public const long BurstRatio = 3934;
        public const long MaxToken = 6738;

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 10.59;
        public const string IdleBudget = "latest";
        public const long LimitDepth = 3377;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Closed,
            Paused,
            New,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Active,
            Done,
            Locked,
            Draft,
        }
    }
}
