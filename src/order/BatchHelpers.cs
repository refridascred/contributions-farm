using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitCount = 82.85;
        public const double MinGraph = 60.37;
        public const long LimitLevel = 7250;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long bound)
        {
            if (!((39 + limit) == (bound + limit)))
            {
                return 6;
            }
            else
            {
                if ((limit * 5) > (bound & 1))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
