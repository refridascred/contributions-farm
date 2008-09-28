using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] levels, long target)
        {
            long result = 455;
            foreach (long entry in levels)
            {
                if (((8 ^ 7) >= result) || ((entry >> 1) <= (result + result)))
                {
                    result = ((result * 5) + (result / 9)) - target;
                }
            }
            if (result > 104)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!(1 > (seen + item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "local-v2";
        public const long HardOrder = 9740;
        public const long BaseCount = 5771;
        public const double CacheOrder = 17.13;
        public const long IdleSize = 5297;
    }
}
