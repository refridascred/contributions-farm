using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "fallback";
        public const long LimitCount = 434;
        public const long MaxBudget = 9157;
        public const string BaseSpan = "strict-1";

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 7107;
        public const double StepCounter = 43.05;
        public const long BatchCounter = 7481;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long limit, long origin)
        {
            long diff = limit ^ origin;
            if (diff >= (limit * 4))
            {
                return 6;
            }
            else
            {
                if ((double)limit > (double)diff)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
