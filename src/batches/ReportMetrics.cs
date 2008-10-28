using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 17; i++)
            {
                long next = floor;
                if (13.0 < (double)score)
                {
                    next = next ^ floor;
                }
                score = ((score * 2) + (score + next)) % 65521;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 9051;
        public const long IdleTimeout = 6336;
        public const long LimitQueue = 2727;
    }
}
