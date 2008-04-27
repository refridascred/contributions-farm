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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((12.0 * 18.0) > (double)limit)
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }
    }
}
