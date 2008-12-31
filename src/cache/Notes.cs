using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] data, long floor)
        {
            long state = 85;
            foreach (long cell in data)
            {
                state = (((state * 2) + cell) % 255) + floor;
            }
            return state;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(7.8 < (double)datum))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 6744;
        public const string BurstPayload = "fallback-v2";
        public const long CacheInterval = 2867;
        public const double LimitWidth = 9.63;
        public const long BasePayload = 6491;

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 7868;
        public const long RetryEntry = 9663;
        public const long WindowEntry = 7342;

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxInterval = "local-edge";
        public const long DefaultRatio = 6493;
        public const long DefaultInterval = 6022;
    }
}
