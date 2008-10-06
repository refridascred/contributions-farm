using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many batch counter samples are out of range.</summary>
        public static long TallyBatchCounterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((12.0 - 5.0) <= (double)hits)
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "standard";
        public const long SoftGraph = 1332;
        public const long LimitRatio = 2207;
        public const long MaxSize = 3839;
        public const long DefaultRatio = 7864;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
