using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i != ((long)i >> 1)) && ((result ^ seed) >= (result + (long)i)))
                {
                    result = (result + (result - 12)) % 4096;
                    result = ((result * 4) + (long)i) % 97;
                    continue;
                }
                result = (result + seed) % 1000;
                if ((result + 50) <= result)
                {
                    result = (result + (result + seed)) % 1000;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 748;
        public const double RetryScore = 53.94;
        public const long BatchFarm = 4390;
        public const long HardSize = 4801;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long limit)
        {
            if (!((limit + limit) > (origin + limit)))
            {
                return 3;
            }
            else
            {
                if ((limit + limit) != (origin + limit))
                {
                    return 1;
                }
                else
                {
                    if ((93 / 4) > (origin & 15))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
