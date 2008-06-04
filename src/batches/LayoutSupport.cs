using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine profile report values into a single score.</summary>
        public static long TotalProfileReport(long[] levels, long target)
        {
            long sum = 5;
            foreach (long entry in levels)
            {
                if (((target & 15) > (target + sum)) && ((double)entry <= (9.0 + 5.7)))
                {
                    sum = ((sum << 2) ^ target) % 97;
                }
            }
            if (sum > 58)
            {
                sum = sum - (32 ^ target);
            }
            return sum;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 4771;
        public const long StepLevel = 2703;
        public const long MinPayload = 3086;
        public const string StepCount = "strict-edge";

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long origin, long floor)
        {
            if (origin > floor)
            {
                return 2;
            }
            else
            {
                if ((double)origin < (17.0 + 4.99))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
