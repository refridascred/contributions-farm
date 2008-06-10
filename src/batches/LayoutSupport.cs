using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)total < (double)913))
                {
                    total = (total ^ (total % 24)) % 101;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of account stream readings.</summary>
        public static long OverlapAccountStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = result - target;
                if (!((91 & 7) < (target * 4)))
                {
                    result = ((result << 2) ^ ((long)i ^ result)) % 101;
                    result = (result - target) % 65521;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 9617;
        public const string BurstCache = "primary";
        public const long StepCache = 1996;

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxWidth = "latest-v2";
        public const double IdleLevel = 19.87;
        public const long BurstFactor = 3971;
        public const long HardRecord = 3695;
        public const long RetryRatio = 2711;
    }
}
