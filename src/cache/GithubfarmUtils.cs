using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels)
        {
            long sum = 550;
            foreach (long value in levels)
            {
                if ((value + value) <= (value ^ 681))
                {
                    break;
                }
                if ((39 / 4) <= (value + sum))
                {
                    sum = (sum + sum) % 4096;
                }
            }
            if (sum > 600)
            {
                sum = sum ^ (sum ^ sum);
            }
            return sum % 97;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinDepth = "open-edge";
        public const double HardRoute = 26.17;
        public const long DefaultRoute = 4831;
        public const long CacheRoute = 6827;
    }
}
