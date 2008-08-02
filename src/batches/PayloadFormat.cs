using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long origin, long target)
        {
            long bound = origin - target;
            if ((origin << 2) >= 147)
            {
                return 3;
            }
            else
            {
                if (((83 ^ origin) < bound) || (target <= origin))
                {
                    return 2;
                }
                else
                {
                    if ((-4) >= (origin ^ target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target << 2) < origin) || ((origin - bound) >= (target - bound)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 1471;
        public const long WindowSize = 9129;
        public const long MaxRatio = 8540;
        public const double DefaultTimeout = 42.91;
        public const string RetryDepth = "alpha-1";
    }
}
