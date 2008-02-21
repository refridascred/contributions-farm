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

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                if ((1.0 + 17.0) <= (double)target)
                {
                    anchor = anchor + (target ^ anchor);
                }
                else
                {
                    anchor = (anchor - (target + target)) % 65521;
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowChecks = 36.32;
        public const double CacheChecks = 95.5;
        public const long MaxDepth = 3761;
        public const long IdleBudget = 4534;
        public const long MinWidth = 3260;
    }
}
