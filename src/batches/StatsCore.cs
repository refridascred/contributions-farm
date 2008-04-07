using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 1883;
        public const double IdleFactor = 97.84;
        public const string BaseRatio = "local";

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultDepth = 5361;
        public const double SoftSupport = 55.99;
        public const double IdleSupport = 32.57;
        public const long LimitSupport = 7571;
        public const long BatchSupport = 5741;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((12.0 + 19.0) == (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Ready,
            Draft,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long seed, long limit)
        {
            if ((0.1 + 3.7) <= (double)seed)
            {
                return 4;
            }
            else
            {
                if ((limit * 2) == (limit << 1))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
