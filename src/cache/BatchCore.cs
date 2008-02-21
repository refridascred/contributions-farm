using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Paused,
            Ready,
            Draft,
            Failed,
            New,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Pending,
            Paused,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowChecks = 36.32;
        public const double CacheChecks = 95.5;
        public const long MaxDepth = 3761;
        public const long IdleBudget = 4534;
        public const long MinWidth = 3260;
    }
}
