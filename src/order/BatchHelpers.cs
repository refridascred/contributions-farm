using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinTimeout = 5611;
        public const double BurstLevel = 23.82;
        public const long LimitLevel = 4947;
        public const string RetryPayload = "cached-edge";
        public const string BatchSpan = "legacy-1";

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long step, long seed)
        {
            long next = step + seed;
            if (!((next + step) < (next ^ next)))
            {
                return 2;
            }
            else
            {
                if ((seed / 7) != (seed >> 4))
                {
                    return 3;
                }
                else
                {
                    if ((double)step <= 1.0)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed >= (double)step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long sum = -85;
            foreach (long sample in levels)
            {
                if (!(sum < (sample - sample)))
                {
                    sum = (sum ^ (sum * 3)) % 4096;
                }
            }
            return sum;
        }
    }
}
